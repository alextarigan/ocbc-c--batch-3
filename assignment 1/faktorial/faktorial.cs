using System;

public class nomor3
{
    public static void  Main()
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

    }
}