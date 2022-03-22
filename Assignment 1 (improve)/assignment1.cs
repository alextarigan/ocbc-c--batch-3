using System;

public class Assignment1
{
    public static void  Main()
    {
      int pilihan=0;
      while(pilihan != 8)
      {
          Console.WriteLine("===Main Menu===");
          Console.WriteLine("1. Segitiga Alfabet");
          Console.WriteLine("2. Segitiga Angka");
          Console.WriteLine("3. Faktorial");
          Console.WriteLine("4. Balik Angka");
          Console.WriteLine("5. Convert Angka To string");
          Console.WriteLine("6. Balik huruf");
          Console.WriteLine("7. Tentang Saya");
          Console.WriteLine("8. Keluar");
          Console.Write("\nMasukkan Pilihan : ");
          pilihan = int.Parse(Console.ReadLine());

          switch(pilihan)
          {
            case 1:
            {
                int range;
                Console.Write("Enter the Range = ");
                range = int.Parse(Console.ReadLine());
                for(int a=1; a<=range; a++)
                {
                    for(int b=range-1; b >=a; b--)
                    {
                        Console.Write(" ");
                    }
                    for(int c=1; c<a; c++)
                    {
                        Console.Write(Convert.ToChar(c+64));
                    }
                    for(int j=a; j >0; j--)
                    {
                        Console.Write(Convert.ToChar(j+64));
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
                break;
            }
            case 2:
            {
                int range;
                Console.Write("Enter the Range = ");
                range = int.Parse(Console.ReadLine());
                for(int a=1; a<=range; a++)
                {
                    for(int b=range-1; b >=a; b--)
                    {
                        Console.Write(" ");
                    }
                    for(int c=1; c<a; c++)
                    {
                        Console.Write(c);
                    }
                    for(int j=a; j >0; j--)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
                break;
            }
            case 3:
            {
                int number,hasil=0;
                Console.Write("Enter any Number : ");
                number = Convert.ToInt32(Console.ReadLine());
                int i = number-1;
                hasil = number;
                do
                {
                        hasil *= i;
                        i--;
                }while(i>=1);
                Console.WriteLine("Factorial of {0} is : {1}",number,hasil);
                Console.ReadKey();
                break;
            }
            case 4:
            {
                int number,balik=0,temp;
                Console.Write("Enter a Number: ");
                number = Convert.ToInt32(Console.ReadLine());
                do
                {
                    temp = number % 10;
                    number /=  10;
                    balik = balik * 10 + temp;

                }while(number >0);
                Console.WriteLine("Reversed Number: {0}",balik);
                Console.ReadKey();
                break;
            }
            case 5:
            {
                string[] angka = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
                int number;
                string kata;
                Console.Write("Enter the Number = ");
                number = Convert.ToInt32(Console.ReadLine());
                kata = Convert.ToString(number);

                char[] data = kata.ToCharArray();
                for(int i=0; i < data.Length; i++)
                {
                    int idx;
                    idx = Convert.ToInt32(data[i]-48) ;
                    Console.Write($"{angka[idx]} ");
                }
                Console.ReadKey();
                break;
            }
            case 6:
            {
                string kata;
                Console.Write("Enter a Text: ");
                kata = Console.ReadLine();
                char[] data =  kata.ToCharArray();
                Array.Reverse(data);
                
                foreach(char i in data)
                    Console.Write(i);
                Console.ReadKey();
                break;
            }
            case 7:
            {
                string[] biodata = new string[8]
                {
                    "Nama : Alexander Radianta Tarigan", "Jenis Kelamin : Laki-Laki", "Alamat : Jl. Singosari No.1 Medan",
                    "Hobi : Bersepeda", "Umur : 22", "Pekerjaan : Tukang Pijit Keyboard", "Jurusan : Teknik Informatika",
                    "Nama Kampus : STMIK Mikroskil Medan"
                };
                Console.WriteLine("===Tentang Saya===");
                foreach(string data in biodata)
                    Console.WriteLine(data);
                Console.ReadKey();
                break;
            }
            default:
            {
                Console.WriteLine("Terima kasih telah menggunakan aplikasi ini");
                break;
            }
          }
      }
    }
}