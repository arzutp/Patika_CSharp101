using System;
using System.Collections;

namespace Odev2Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
            //(ArrayList sınıfını kullanara yazınız.)
            //Negatif ve numeric olmayan girişleri engelleyin.
            //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            ArrayList asal = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();
            int sayi = 0;
            Console.WriteLine("20 tane pozitif sayı giriniz");
            for(int i=0;i<20;i++){
                Console.WriteLine((i+1)+". sayıyı giriniz");
                sayi = Convert.ToInt32(Console.ReadLine());
                if(sayi<0){
                    Console.WriteLine("yeniden sayi giriniz: ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                }
                if(AsalMi(sayi))
                    asal.Add(sayi);
                else
                    asalOlmayan.Add(sayi);
                
            }

            Console.WriteLine(asal.Count);
            Console.WriteLine(asalOlmayan.Count);
            asal.Sort();
            asal.Reverse();

            Console.WriteLine("Sıralı asal sayılar");
            int toplamAsal = 0;
            foreach (var item in asal)
            {
                toplamAsal += (int)item;
                Console.WriteLine(item);
            }

            asalOlmayan.Sort();
            asalOlmayan.Reverse();
            Console.WriteLine("Sıralı asal olmayan sayılar");
            int toplam = 0;
            foreach (var item in asalOlmayan)
            {
                toplam += (int)item;
                Console.WriteLine(item);
            }

            //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            Console.WriteLine("ortalama");
            Console.WriteLine((double)toplamAsal/asal.Count);
            Console.WriteLine((double)toplam/asalOlmayan.Count);

           
            

        }

        private static bool AsalMi(int sayi)
        {
            
            if (sayi == 2) 
                return true;
            if(sayi%2==0)
                return false;
          var temp = (int)Math.Floor(Math.Sqrt(sayi));

            for (int i = 3; i <= temp; i += 2)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    } 
    
}

