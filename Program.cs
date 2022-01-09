using System;

namespace Donguler_While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // //while Loop
            // //1 den başlayarak consoleden girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıralım.
            // System.Console.WriteLine("Bir Sayı Griniz.");
            // int sayi = int.Parse(Console.ReadLine());
            // int sayac = 1;
            // int toplam = 0;
            // while (sayac <= sayi) // Buraya yazılan İfade true olduğu sürece alttaki kod bloğu çalışacaktır.
            // {
            //  toplam +=sayac;
            //  sayac++;    
            // }
            // System.Console.WriteLine(toplam/sayi);

            // // 'a' dan 'z' ye kadar tüm harfleri console a yazdır.
            // char character = 'a';
            // while (character < 'z')
            // {
            //      System.Console.Write(character);
            //      character++;
            // }

            System.Console.WriteLine("*** Foreach ***");
            string[] arabalar = {"BMW","MERCEDES","FORD","TOYOTA","NISSAN"};


            foreach (var item in arabalar)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
