using Modbus.Device;
using Modbus.Extensions.Enron;
using System.Diagnostics.Metrics;
using System.IO.Ports;
using System.Linq.Expressions;
using System.Windows.Forms;


namespace Modbus_Com
{
    public partial class Form1 : Form
    {


        SerialPort serialPort = new SerialPort();
        ModbusSerialMaster master;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (var port in SerialPort.GetPortNames())
            {

                PortBox.Items.Add(port);
                PortBox.SelectedIndex = 0;
                Function_Box.SelectedIndex = 0;
                Discon_Btn.Enabled = false;
                Text_Com.Visible = false;
                Read_Btn.Enabled = false;
                Vga_green.Visible = false;
                Vga_Red.Visible = false;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            int baudratetest;

            if (string.IsNullOrEmpty(BaudRateBox.Text))
            {
                MessageBox.Show($"Connection Failed\n Error Cause : Baud Rate Null", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if ((baudratetest = Convert.ToInt16((BaudRateBox.Text))) < 2400)
            {
                MessageBox.Show($"Connection Failed\n Error Cause : Baud Rate < 2400", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                serialPort.PortName = PortBox.Text;
                serialPort.BaudRate = Convert.ToInt16(BaudRateBox.Text);
                serialPort.DataBits = 8;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;

                try
                {
                    serialPort.Open();
                    master = ModbusSerialMaster.CreateRtu(serialPort);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Connection Failed\n Error Cause : {ex.Message}", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                if (serialPort.IsOpen)
                {
                    Discon_Btn.Enabled = true;
                    Connect_btn.Enabled = false;
                    PortBox.Enabled = false;
                    BaudRateBox.Enabled = false;
                    Slave_Id.Enabled = false;
                    Text_Com.Text = "Connected"; Text_Com.ForeColor = Color.Green;
                    Text_Com.Visible = true;
                    Read_Btn.Enabled = true;
                    Vga_green.Visible = true;
                    Vga_Red.Visible = false;

                }
            }
        }

            private void Read_Btn_Click(object sender, EventArgs e)
        {
            int counter = 0;
            switch (Function_Box.SelectedIndex)
            {

                //Read Coils(0x)--------------------------------------------------------
                case 0:

                    try
                    {
                        byte slaveIdRC = Convert.ToByte(Slave_Id.Text);
                        ushort first_regRC = Convert.ToUInt16(First_reg_Add.Text);
                        ushort numberOfPointsRC = Convert.ToUInt16(Number_of_reg.Text);
                        bool[] dataRC = master.ReadCoils(slaveIdRC, first_regRC, numberOfPointsRC);
                        
                        

                        foreach (var rc in dataRC)
                        {
                            string currentTime = DateTime.Now.ToString("HH:mm:ss - yyyy-MM-dd");
                            Read_Value_Box.Text += ($"Value: {rc} \t Time: {currentTime}    Function: 0x{first_regRC}-{counter}");
                            Read_Value_Box.AppendText(Environment.NewLine);
                            counter++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Connection Failed\n Error Cause : {ex.Message}", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    break;

                //Read Discrete Inputs(1x)-------------------------------------------------
                case 1:

                    try
                    {
                        byte slaveIdRDI = Convert.ToByte(Slave_Id.Text);
                        ushort first_regRDI = Convert.ToUInt16(First_reg_Add.Text);
                        ushort numberOfPointsRDI = Convert.ToUInt16(Number_of_reg.Text);
                        bool[] dataRDI = master.ReadInputs(slaveIdRDI, first_regRDI, numberOfPointsRDI);

                        foreach (var rdi in dataRDI)
                        {
                            string currentTime = DateTime.Now.ToString("HH:mm:ss - yyyy-MM-dd");
                            Read_Value_Box.Text += ($"Value: {rdi} \t Time: {currentTime}    Function: 1x{first_regRDI}-{counter}");
                            Read_Value_Box.AppendText(Environment.NewLine);
                            counter++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Connection Failed\n Error Cause : {ex.Message}", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    break;

                //Read Holding Register(4x)-------------------------------------------------
                case 2:

                    try
                    {
                        byte slaveIdRHR = Convert.ToByte(Slave_Id.Text);
                        ushort first_regRHR = Convert.ToUInt16(First_reg_Add.Text);
                        ushort numberOfPointsRHR = Convert.ToUInt16(Number_of_reg.Text);
                        ushort[] dataRHR = master.ReadHoldingRegisters(slaveIdRHR, first_regRHR, numberOfPointsRHR);

                        foreach (var rhr in dataRHR)
                        {
                            string currentTime = DateTime.Now.ToString("HH:mm:ss - yyyy-MM-dd");
                            Read_Value_Box.Text += ($"Value: {rhr} \t Time: {currentTime}    Function: 4x{first_regRHR}-{counter}");
                            Read_Value_Box.AppendText(Environment.NewLine);
                            counter++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Connection Failed\n Error Cause : {ex.Message}", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    break;

                //Read Input Registers(3x)-------------------------------------------------
                case 3:

                    try
                    {
                        byte slaveIdRIR = Convert.ToByte(Slave_Id.Text);
                        ushort first_regRIR = Convert.ToUInt16(First_reg_Add.Text);
                        ushort numberOfPointsRIR = Convert.ToUInt16(Number_of_reg.Text);
                        ushort[] dataRIR = master.ReadInputRegisters(slaveIdRIR, first_regRIR, numberOfPointsRIR);

                        foreach (var rir in dataRIR)
                        {
                            string currentTime = DateTime.Now.ToString("HH:mm:ss - yyyy-MM-dd");
                            Read_Value_Box.Text += ($"Value: {rir} \t Time: {currentTime}    Function: 3x{first_regRIR}-{counter}");
                            Read_Value_Box.AppendText(Environment.NewLine);
                            counter++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Connection Failed\n Error Cause : {ex.Message}", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    break;
            }


        }

        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            Read_Value_Box.Clear();
        }

        private void Discon_Btn_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                Discon_Btn.Enabled = false;
                Connect_btn.Enabled = true;
                PortBox.Enabled = true;
                BaudRateBox.Enabled = true;
                Slave_Id.Enabled = true;
                Text_Com.Text = "Disconnected"; Text_Com.ForeColor = Color.Red;
                Text_Com.Visible = true;
                Read_Btn.Enabled = false;
                Vga_green.Visible = false;
                Vga_Red.Visible = true;

            }
        }
    }
}
