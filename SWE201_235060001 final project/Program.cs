using System;

namespace LaptopRental
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalManager manager = new RentalManager();
            manager.SetupData(); // Başlangıç verilerini yükledik

            Console.WriteLine("========================================");
            Console.WriteLine("  TOROS ÜNİ. LAPTOP KİRALAMA SİSTEMİ");
            Console.WriteLine("========================================");

            while (true) // Sonsuz döngü 5 girilince çıkar
            {
                Console.WriteLine("\nLütfen bir işlem seçin:");
                Console.WriteLine("1. Cihazları Listele");
                Console.WriteLine("2. Cihaz Kirala");
                Console.WriteLine("3. Cihaz İade Et");
                Console.WriteLine("4. Yeni Cihaz Ekle");
                Console.WriteLine("5. Çıkış");
                Console.Write("Seçiminiz: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    manager.ListAllDevices();
                }
                else if (choice == "2")
                {
                    Console.Write("Kiralanacak Cihaz ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Öğrenci Adı: ");
                    string name = Console.ReadLine();
                    manager.RentDevice(id, name);
                }
                else if (choice == "3")
                {
                    Console.Write("İade Edilecek Cihaz ID: ");
                    int id = int.Parse(Console.ReadLine());
                    manager.ReturnDevice(id);
                }
                else if (choice == "4")
                {
                    Console.Write("Marka: ");
                    string brand = Console.ReadLine();
                    Console.Write("Model: ");
                    string model = Console.ReadLine();
                    manager.AddNewDevice(brand, model);
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Sistemden çıkılıyor...");
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz işlem!");
                }
            }
        }
    }
}