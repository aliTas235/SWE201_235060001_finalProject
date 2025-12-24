using System;
using System.Collections.Generic; //listeler için

namespace LaptopRental
{
    public class RentalManager
    {
        // Cihazları ve kiralama kayıtlarını tuttuğumuz listeler
        public List<Device> Devices = new List<Device>();

        // Sahte veri yapalım ki test edelim:
        public void SetupData()
        {
            Devices.Add(new Device(1, "MacBook", "Pro M1"));
            Devices.Add(new Device(2, "Dell", "XPS 15"));
            Devices.Add(new Device(3, "Lenovo", "ThinkPad"));
        }

        // 1. lisele
        public void ListAllDevices()
        {
            Console.WriteLine("\n--- CİHAZ LİSTESİ ---");
            foreach (var device in Devices)
            {
                device.ShowInfo();
            }
        }

        // 2. kirala
        public void RentDevice(int deviceId, string studentName)
        {
            // Cihazın id si aslında sırası ve onun ile buluruz
            var deviceToRent = Devices.Find(d => d.Id == deviceId);

            if (deviceToRent != null)
            {
                if (deviceToRent.IsRented)
                {
                    Console.WriteLine("HATA: Bu cihaz zaten başkasında!");
                }
                else
                {
                    deviceToRent.IsRented = true; // Durumunu güncellemesi
                    Console.WriteLine($"BAŞARILI: {deviceToRent.Brand} cihazı, {studentName} adlı öğrenciye verildi.");
                }
            }
            else
            {
                Console.WriteLine("HATA: Böyle bir ID bulunamadı.");
            }
        }

        // 3. iade aldık
        public void ReturnDevice(int deviceId)
        {
            var device = Devices.Find(d => d.Id == deviceId);
            if (device != null)
            {
                device.IsRented = false;
                Console.WriteLine("İADE ALINDI: Cihaz tekrar stoğa girdi.");
            }
        }

        // 4. yeni cihaz
        public void AddNewDevice(string brand, string model)
        {
            // ID ürettik
            int newId = Devices.Count + 1;
            Device newDevice = new Device(newId, brand, model);
            Devices.Add(newDevice);
            Console.WriteLine("Yeni cihaz envantere eklendi.");
        }
    }
}