using System;

namespace InheritancePesawat
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            PesawatTempur pswttempur = new PesawatTempur();

            pesawat.Nama = "Helly";
            pesawat.JumlahRoda = 3;
            pesawat.Ketinggian = "1000 Kaki";
            pesawat.JumlahPenumpang = "3 penumpang";
            pswttempur.Nama = "AZ500TPU";
            pswttempur.JumlahRoda = 5;
            pswttempur.Ketinggian = "200 kaki";
            pswttempur.JumlahPenumpang = "2 Penumpang plus kopilot dan asistance";

            pesawat.terbang();
            pswttempur.terbangtinggi();
            Console.Read();
        }
    }
}
