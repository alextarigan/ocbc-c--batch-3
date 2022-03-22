using System;

public class tugasinputan{
    public static void Main(string[] args){
        string username,password,jenisKelamin,jawaban;
        int age,nilaiPertama,nilaiKedua,nilaiKetiga,total;
        double rata;
        bool statusNikah=false,statusJenkel,ulang;

        Console.Write("Masukkan Username : ");
        username = Console.ReadLine();
        Console.Write("Masukkan Password : ");
        password = Console.ReadLine();
        Console.Write("Masukkan Umur : ");
        age = int.Parse(Console.ReadLine());
        do{
            Console.Write("Masukkan Jenis kelamin: (Laki-Laki/Perempuan) : ");
            jenisKelamin = Console.ReadLine();
            
            statusJenkel = jenisKelamin == "Laki-Laki" || jenisKelamin == "Perempuan";
                
        }while(!statusJenkel);
        
        do{
            Console.Write("Status Nikah (ya/tidak): ");
            jawaban = Console.ReadLine();
            ulang = jawaban == "ya" || jawaban == "tidak";
        }while(!ulang);
        
        if(jawaban== "ya")
        {
            statusNikah = true;
        }
        Console.Write("Nilai Pertama : ");
        nilaiPertama = int.Parse(Console.ReadLine());
        Console.Write("Nilai Kedua : ");
        nilaiKedua = int.Parse(Console.ReadLine());
        Console.Write("Nilai Ketiga : ");
        nilaiKetiga = int.Parse(Console.ReadLine());
        total = nilaiPertama+nilaiKedua+nilaiKetiga;
        rata = total/3.0;

        Console.WriteLine("===Biodata===");
        Console.WriteLine($"Umur: {age}");
        Console.WriteLine($"Username: {username}");
        Console.WriteLine($"Jenis Kelamin: {jenisKelamin}");
        Console.WriteLine($"Status Nikah : {statusNikah}");
        
        Console.WriteLine("Aritmatika");
        Console.WriteLine("Total Nilai : "+total);
        Console.WriteLine("Rata-Rata Nilai : "+rata);
    }
}