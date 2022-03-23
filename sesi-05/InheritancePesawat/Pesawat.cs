using System;
namespace InheritancePesawat
{
    public class Pesawat
    {
        private string nama;
        private int jumlahRoda;
        private string ketinggian;
        private string jumlahPenumpang;

        public string Nama
        {
            get {return nama;}
            set {nama = value;}
        }
        public int JumlahRoda
        {
            get {return jumlahRoda;}
            set {jumlahRoda = value;}
        }
        public string Ketinggian
        {
            get {return ketinggian;}
            set { ketinggian = value;}
        }
        public string JumlahPenumpang
        {
            get {return jumlahPenumpang;}
            set {jumlahPenumpang = value;}
        }

        public void terbang()
        {
            Console.WriteLine("Pesawat dengan nama {0}, sedang take off", this.Nama);
        }
    }
}