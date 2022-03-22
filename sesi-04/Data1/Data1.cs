using System;

public class Data1
{
    public static void  Main()
    {
        int[] aAngka = new int[5];
        string[] aNama = new string[] { "Joni", "Meri", "David" };
        object[] aObjek =  {20.33, "Lorem ipsum", DateTime.Now, true, 'D'};

        foreach(string nama in aNama)
        {
            Console.WriteLine(nama);
        }
        foreach(object objek in aObjek)
        {
            Console.WriteLine(objek);
        }
        
    }
}