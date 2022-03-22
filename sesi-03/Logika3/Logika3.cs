using System;

public class Logika3
{
    public static void  Main()
    {
        string username,password;

        Console.Write("Username : ");
        username = Console.ReadLine();
        Console.Write("Password : ");
        password = Console.ReadLine();

        if(username == "ocbc" && password == "bootcamp")
            Console.WriteLine("Anda Berhasil Login");
        else
            Console.WriteLine("Username atau Password anda salah");
    }
}