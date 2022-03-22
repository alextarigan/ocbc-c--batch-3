using System;

public class nomor5
{
    public static  void  Main()
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
    }
}