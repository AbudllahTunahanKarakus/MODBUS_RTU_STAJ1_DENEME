# MODBUS_RTU_STAJ1_DENEME
ModbusRtu kütüphanesini denemek amaçlı yapılan denemeler.  
# Modbus RTU Denemeleri (EasyModbus)

Bu repository, C# ile easymodbus kütüphanesi kullanılarak yapılan Modbus RTU haberleşme denemelerini içermektedir.

Amaç, Modbus RTU protokolünü pratik olarak anlamak ve seri port üzerinden cihaz haberleşmesini test etmektir.

---

## 🚀 Yapılan Çalışmalar

Bu projede aşağıdaki işlemler test edilmiştir:

- Serial port üzerinden Modbus RTU bağlantısı kurma  
- Slave cihazdan veri okuma (Holding Registers)  
- Register yazma işlemleri  
- Tekli ve çoklu veri gönderimi  
- Bağlantı kontrolü ve hata senaryoları  

---

## 🔹 Kullanılan Teknolojiler

- C#  
- EasyModbus kütüphanesi  
- Serial Port (COM port haberleşmesi)  

---

🎯 Amaç
Bu proje, Modbus RTU haberleşmesini öğrenmek ve endüstriyel otomasyon sistemlerinde seri haberleşme mantığını pratik olarak deneyimlemek amacıyla yapılmıştır.

📌 Notlar
Bu proje bir deneme / öğrenme projesidir
Gerçek cihazlar ile test edilmiştir
Geliştirmeye ve genişletmeye açıktır


## 🛠️ Örnek Kullanımlar

### ✔ Bağlantı Kurma
```csharp
ModbusClient client = new ModbusClient("COM3");
client.Baudrate = 9600;
client.Connect();

int[] values = client.ReadHoldingRegisters(0, 10);

client.WriteSingleRegister(0, 123);

client.WriteMultipleRegisters(0, new int[] { 10, 20, 30 });
