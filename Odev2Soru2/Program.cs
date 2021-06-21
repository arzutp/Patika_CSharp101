using System;
using System.Collections;

namespace Odev2Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
            //her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve 
            //ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
            ArrayList sayi = new ArrayList();
            Console.WriteLine("20 tane sayı giriniz");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i + 1 + ". sayıyı giriniz: ");
                int number = int.Parse(Console.ReadLine());
                sayi.Add(number);
            }
            sayi.Sort();
            ArrayList max = new ArrayList();
            ArrayList min = new ArrayList();
            for (int i = 0; i < 3; i++)
            {
                min.Add(sayi[i]);
            }
            for (int i = sayi.Count-1; i >= sayi.Count-3; i--)
            {
                max.Add(sayi[i]);
            }

            Console.WriteLine("Ortalama");
            int maxT = 0;
            foreach (var item in max)
            {
                maxT +=(int)item;
            }

            int minT = 0;
            foreach (var item in min)
            {
                minT +=(int)item;
            }

            Console.WriteLine("En büyük değerler ortalaması: " + (double)maxT/3);
            Console.WriteLine("En küçük değerler ortalaması: " + (double)minT/3);

        }
    }
}
