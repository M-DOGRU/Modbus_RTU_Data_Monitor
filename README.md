# Modbus RTU Data Monitor

Modbus RTU Data Monitor, Modbus RTU protokolü kullanarak veri okumak için geliştirilmiş bir uygulamadır. Bu program, **Read Coils**, **Read Discrete Inputs**, **Read Holding Registers**, ve **Read Input Registers** gibi temel Modbus fonksiyonlarını destekler.

## Özellikler
- Seri port bağlantısı üzerinden Modbus RTU cihazları ile iletişim.
- Aşağıdaki Modbus fonksiyonları ile veri okuma:
  - **Read Coils** (Fonksiyon Kodu: 0x01)
  - **Read Discrete Inputs** (Fonksiyon Kodu: 0x02)
  - **Read Holding Registers** (Fonksiyon Kodu: 0x03)
  - **Read Input Registers** (Fonksiyon Kodu: 0x04)
- Baud rate ve slave ID gibi parametrelerin ayarlanabilmesi.
- Modbus cihaza kolayca bağlanma ve okuma işlemlerini gerçekleştirme.

## Kullanım

1. Programı başlatın.
2. Seri port bağlantısını gerçekleştirin ve bağlanmak istediğiniz seri portu program üzerinden seçin.
3. İstenen **baud rate** ve **slave ID** değerlerini girin.
4. Okuma yapmak istediğiniz Modbus fonksiyonunu seçin (**Read Coils**, **Read Discrete Inputs**, **Read Holding Registers**, veya **Read Input Registers**).
5. "Read" tuşuna basarak okuma işlemini başlatın.

### Seri Port Ayarları
- Baud Rate: İhtiyacınıza göre ayarlanabilir.
- Slave ID: Modbus cihazına ait adres.


