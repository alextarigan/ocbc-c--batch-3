using System;

public class balikangka
{
    public static void  Main()
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
       

    }
}