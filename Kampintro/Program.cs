using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            // ilk önce değişkenlerimizi tanımlıyoruz.
            int a, b, sonuc = 0;
            // değişkenlerimize değer aktarılması gerektiğini sölüyoruz.
            Console.WriteLine("\t 1. sayıyı giriniz : ");
            // klavyeden girilen ilk sayıyı "a" değişkenine aktarılmasını sağlıyoruz.
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("\t 2. sayıyı giriniz : ");

            // klavyeden girilen 2. sayının b değişkenine aktarılmasını sağlıyoruz.

            b = int.Parse(Console.ReadLine());

            // işlem seçimi yaptıralım ..
            // işlem tercihini belirlemek için değişken tanımlıyalım.
            int tercih;
            Console.WriteLine("\tToplama işlemi için : 1 \n\t Çıkarma işlemi için : 2  \n\t  Bölme işlemi için : 3 \n\t Çarpma işlemi için : 4 ");
            tercih = int.Parse(Console.ReadLine());
            if (tercih == 1)
            {

                sonuc = a + b;
                Console.WriteLine(sonuc);

            }
            if (tercih == 2)
            {

                sonuc = a - b;
                Console.WriteLine(sonuc);

            }
            if (tercih == 3)
            {

                sonuc = a / b;
                Console.WriteLine(sonuc);

            }

            if (tercih == 4)
            {

                sonuc = a * b;
                Console.WriteLine(sonuc);

            }
            Console.ReadLine();

        }
    }
}

&nbsp;