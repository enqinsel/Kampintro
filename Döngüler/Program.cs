using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //array = dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı" , "Programlamaya başlangıç için temel kurs" , "Java" , "Python" , "C++" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);               //Böyle yaparak dinamikleştirdik. Length özelliği güzel.
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)  // foreach dizilere uygulanır, her bir elemanı tek tek dolaşır ve yazdırır
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");

        }
    }
}
