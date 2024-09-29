namespace Modbus_Com
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PortBox = new ComboBox();
            groupBox1 = new GroupBox();
            Slave_Id = new NumericUpDown();
            label3 = new Label();
            Discon_Btn = new Button();
            Connect_btn = new Button();
            BaudRateBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Text_Com = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            Function_Box = new ComboBox();
            label6 = new Label();
            Number_of_reg = new TextBox();
            First_reg_Add = new TextBox();
            Read_Btn = new Button();
            Read_Value_Box = new RichTextBox();
            Clear_Btn = new Button();
            Vga_green = new PictureBox();
            Vga_Red = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Slave_Id).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Vga_green).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Vga_Red).BeginInit();
            SuspendLayout();
            // 
            // PortBox
            // 
            PortBox.FormattingEnabled = true;
            PortBox.Location = new Point(112, 36);
            PortBox.Name = "PortBox";
            PortBox.Size = new Size(82, 28);
            PortBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(Slave_Id);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Discon_Btn);
            groupBox1.Controls.Add(Connect_btn);
            groupBox1.Controls.Add(BaudRateBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(PortBox);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 181);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Port Info";
            // 
            // Slave_Id
            // 
            Slave_Id.Location = new Point(112, 127);
            Slave_Id.Name = "Slave_Id";
            Slave_Id.Size = new Size(82, 27);
            Slave_Id.TabIndex = 8;
            Slave_Id.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(6, 129);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 7;
            label3.Text = "Slave Id:";
            label3.Click += label3_Click;
            // 
            // Discon_Btn
            // 
            Discon_Btn.ForeColor = SystemColors.ControlText;
            Discon_Btn.Location = new Point(238, 85);
            Discon_Btn.Name = "Discon_Btn";
            Discon_Btn.Size = new Size(105, 28);
            Discon_Btn.TabIndex = 5;
            Discon_Btn.Text = "Disconnect";
            Discon_Btn.UseVisualStyleBackColor = true;
            Discon_Btn.Click += Discon_Btn_Click;
            // 
            // Connect_btn
            // 
            Connect_btn.ForeColor = SystemColors.ControlText;
            Connect_btn.Location = new Point(238, 35);
            Connect_btn.Name = "Connect_btn";
            Connect_btn.Size = new Size(105, 28);
            Connect_btn.TabIndex = 4;
            Connect_btn.Text = "Connect";
            Connect_btn.UseVisualStyleBackColor = true;
            Connect_btn.Click += Connect_btn_Click;
            // 
            // BaudRateBox
            // 
            BaudRateBox.Location = new Point(112, 82);
            BaudRateBox.Name = "BaudRateBox";
            BaudRateBox.Size = new Size(82, 27);
            BaudRateBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(6, 85);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "Baud Rate:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 1;
            label1.Text = "Port:";
            // 
            // Text_Com
            // 
            Text_Com.AutoSize = true;
            Text_Com.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Text_Com.Location = new Point(18, 197);
            Text_Com.Name = "Text_Com";
            Text_Com.Size = new Size(39, 23);
            Text_Com.TabIndex = 6;
            Text_Com.Text = "Test";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(6, 85);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 2;
            label4.Text = "First Register Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(6, 130);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 3;
            label5.Text = "No Of Register:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Function_Box);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(Number_of_reg);
            groupBox2.Controls.Add(First_reg_Add);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.ForeColor = Color.MidnightBlue;
            groupBox2.Location = new Point(378, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(294, 181);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Read Info";
            // 
            // Function_Box
            // 
            Function_Box.FormattingEnabled = true;
            Function_Box.Items.AddRange(new object[] { "Read Coils(0x)", "Read Discrete Inputs(1x)", "Read Holding Register(4x)", "Read Input Registers(3x)" });
            Function_Box.Location = new Point(74, 36);
            Function_Box.Name = "Function_Box";
            Function_Box.Size = new Size(211, 28);
            Function_Box.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(6, 39);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 7;
            label6.Text = "Function:";
            // 
            // Number_of_reg
            // 
            Number_of_reg.Location = new Point(203, 127);
            Number_of_reg.Name = "Number_of_reg";
            Number_of_reg.Size = new Size(82, 27);
            Number_of_reg.TabIndex = 6;
            // 
            // First_reg_Add
            // 
            First_reg_Add.Location = new Point(203, 82);
            First_reg_Add.Name = "First_reg_Add";
            First_reg_Add.Size = new Size(82, 27);
            First_reg_Add.TabIndex = 5;
            // 
            // Read_Btn
            // 
            Read_Btn.ForeColor = SystemColors.ControlText;
            Read_Btn.Location = new Point(558, 222);
            Read_Btn.Name = "Read_Btn";
            Read_Btn.Size = new Size(105, 28);
            Read_Btn.TabIndex = 7;
            Read_Btn.Text = "Read";
            Read_Btn.UseVisualStyleBackColor = true;
            Read_Btn.Click += Read_Btn_Click;
            // 
            // Read_Value_Box
            // 
            Read_Value_Box.BackColor = SystemColors.ControlLightLight;
            Read_Value_Box.Location = new Point(18, 223);
            Read_Value_Box.Name = "Read_Value_Box";
            Read_Value_Box.ReadOnly = true;
            Read_Value_Box.Size = new Size(520, 170);
            Read_Value_Box.TabIndex = 5;
            Read_Value_Box.Text = "";
            // 
            // Clear_Btn
            // 
            Clear_Btn.Location = new Point(558, 268);
            Clear_Btn.Name = "Clear_Btn";
            Clear_Btn.Size = new Size(105, 28);
            Clear_Btn.TabIndex = 8;
            Clear_Btn.Text = "Clear";
            Clear_Btn.UseVisualStyleBackColor = true;
            Clear_Btn.Click += Clear_Btn_Click;
            // 
            // Vga_green
            // 
            Vga_green.Image = Properties.Resources.Green;
            Vga_green.Location = new Point(108, 196);
            Vga_green.Name = "Vga_green";
            Vga_green.Size = new Size(40, 27);
            Vga_green.SizeMode = PictureBoxSizeMode.Zoom;
            Vga_green.TabIndex = 9;
            Vga_green.TabStop = false;
            // 
            // Vga_Red
            // 
            Vga_Red.Image = Properties.Resources.Red;
            Vga_Red.Location = new Point(127, 196);
            Vga_Red.Name = "Vga_Red";
            Vga_Red.Size = new Size(40, 27);
            Vga_Red.SizeMode = PictureBoxSizeMode.Zoom;
            Vga_Red.TabIndex = 10;
            Vga_Red.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(725, 427);
            Controls.Add(Vga_Red);
            Controls.Add(Vga_green);
            Controls.Add(Clear_Btn);
            Controls.Add(Read_Btn);
            Controls.Add(Text_Com);
            Controls.Add(Read_Value_Box);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Modbus Data Reader";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Slave_Id).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Vga_green).EndInit();
            ((System.ComponentModel.ISupportInitialize)Vga_Red).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox PortBox;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox BaudRateBox;
        private Label Text_Com;
        private Button Discon_Btn;
        private Button Connect_btn;
        private Label label3;
        private NumericUpDown Slave_Id;
        private Label label4;
        private Label label5;
        private GroupBox groupBox2;
        private TextBox First_reg_Add;
        private TextBox Number_of_reg;
        private RichTextBox Read_Value_Box;
        private Button Read_Btn;
        private Label label6;
        private ComboBox Function_Box;
        private Button Clear_Btn;
        private PictureBox Vga_green;
        private PictureBox Vga_Red;
    }
}
