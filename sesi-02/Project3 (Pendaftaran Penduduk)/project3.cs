using System;

public class helloworld{
    public static void Main(string[] args){
        string nama,alamat;
        int umur;
        Console.WriteLine("=== PROGRAM PENDAFTARAN PENDUDUK ===");
        Console.Write("Masukkan nama: ");
        nama = Console.ReadLine();
        Console.Write("Masukkan alamat: ");
        alamat = Console.ReadLine();
        Console.Write("Masukkan umur: ");
        umur = int.Parse(Console.ReadLine());

        Console.WriteLine("\nTerimakasih!");
        Console.WriteLine("Data Berikut");
        Console.WriteLine($"Nama: {nama}");
        Console.WriteLine($"Alamat: {alamat}");
        Console.WriteLine($"Umur: {umur} tahun");
        Console.WriteLine("SUDAH DISIMPAN!");
    }
}