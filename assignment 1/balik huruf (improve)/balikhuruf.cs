using System;

public class nomor4
{
    public static void  Main()
    {
       string kata;
       Console.Write("Enter a Text: ");
       kata = Console.ReadLine();
       char[] data =  kata.ToCharArray();
       Array.Reverse(data);
       
       foreach(char i in data)
        Console.Write(i);
       

    }
}