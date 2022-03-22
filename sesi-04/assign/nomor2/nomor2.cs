using System;

public class nomor2
{
    public static  void  Main()
    {
        int range;
        Console.Write("Enter the Range = ");
        range = int.Parse(Console.ReadLine());
        for(int a=1; a<range; a++)
        {
            for(int b=range; b >=a; b--)
            {
                Console.Write(" ");
            }
            for(int c=1; c<=a; c++)
            {
                Console.Write(c);
            }
            for(int j=a; j >0; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
        
    }
}