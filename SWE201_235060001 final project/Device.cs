using System;

namespace LaptopRental
{
    //kiralanacak cihazlar class
    public class Device
    {
        public int Id { get; set; }
        public string Brand { get; set; } // Marka (Apple, Dell vs.)
        public string Model { get; set; }
        public bool IsRented { get; set; } // Kiralandı mı?

        // Kurucu
        public Device(int id, string brand, string model)
        {
            Id = id;
            Brand = brand;
            Model = model;
            IsRented = false; // İlk oluştuğunda kiralanmamış olsun
        }

        // ekrana bilgileri yazı rır
        public void ShowInfo()
        {
            string status = IsRented ? "[KİRALANDI]" : "[MÜSAİT]";
            Console.WriteLine($"{Id} - {Brand} {Model} {status}");
        }
    }
}