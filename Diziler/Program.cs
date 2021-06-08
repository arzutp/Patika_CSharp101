using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //diziler aynı tipteki elemanları tutarlar
            string[] renkler = new string[5];
            string[] hayvanlar = {"Kedi", "Köpek", "Yunus"};
            int[] dizi;
            dizi = new int[5];
            renkler[0] = "Mavi";
            Console.WriteLine(hayvanlar[0]);
            dizi[3] = 10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi
            // Klavyeden girilen n tane sayının ortalaması
            Console.WriteLine("Dizi boyutu giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiD = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("lütfen {0}. elemanı giriniz:", i+1);
                sayiD[i] = int.Parse(Console.ReadLine());
            }

            int t = 0;
            foreach (var item in sayiD)           
                t += item;
            
            Console.WriteLine("Ortalama: " + t/diziUzunlugu);


            //Array Sınıfı Methodlar
            int[] sayiDizi = {23,12,4,86,72,3,11,17};
            Console.WriteLine("---------Sırasız liste--------");
            foreach (var item in sayiDizi)
                Console.WriteLine(item);

            Console.WriteLine("---------Sıralı liste---------");
            Array.Sort(sayiDizi);
            foreach (var item in sayiDizi)
                Console.WriteLine(item);

            //clear istenilen dğer kadar 0 atıyor
            Console.WriteLine("------clear methodu-------");
            Array.Clear(sayiDizi,2,2);
            foreach (var item in sayiDizi)
                Console.WriteLine(item);

            //Reverse tersine çevirme işlemi
            Console.WriteLine("-------Reverse--------");
            Array.Reverse(sayiDizi);
            foreach (var item in sayiDizi)
                Console.WriteLine(item);

            //IndexOf verilen dizi içinde elemanın indeksini döner
            Console.WriteLine("-------IndexOf--------");
            Console.WriteLine(Array.IndexOf(sayiDizi,23));

            //Resize yeniden boyutlandırma
            Console.WriteLine("--------Resize--------");
            Array.Resize<int>(ref sayiDizi,9);
            sayiDizi[8]=102;
            foreach (var item in sayiDizi)
                Console.WriteLine(item);
            
        }
    }
}
