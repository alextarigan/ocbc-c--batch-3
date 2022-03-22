using System;

public class Logika8
{
    public static void  Main()
    {
        int i = 0;
        do
        {
            
            i++;
            if(i > 5 )
            {
                if(i % 2 == 1){
                    Console.WriteLine("Lanjutan i = {0}",i);
                    i++;
                }
                    
            }
            else
                Console.WriteLine("i = {0}",i);
                
        }while(i <= 11);
    }
}