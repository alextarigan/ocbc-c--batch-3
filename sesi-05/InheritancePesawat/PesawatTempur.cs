using System;
namespace InheritancePesawat
{
    public class PesawatTempur:Pesawat
    {
        public void terbangtinggi()
            {
                Console.WriteLine("Pesawat tempur dengan nama {0}, yang mempunyai jumlah road {1}, sedang berada pada ketinggian {2} dengan membawa jumlah penumpang sebanyak {3} akan meledakkan senjata", this.Nama, this.JumlahRoda, this.Ketinggian, this.JumlahPenumpang);
            }
    }
}