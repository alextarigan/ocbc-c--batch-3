using System;

namespace Laptop
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop();

            laptop1.merk = "lenovo";
            laptop1.ram = 4;
            laptop1.memory = 123;

            Console.WriteLine("\n Merk Laptop adalah {0}", laptop1.merk);
            Console.WriteLine("\n Kapasitas Ram ada {0}", laptop1.ram);
            Console.WriteLine("\n Kapasitas Memroy ada {0}", laptop1.memory);

            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();

            Console.Read();

        }
    }
}
