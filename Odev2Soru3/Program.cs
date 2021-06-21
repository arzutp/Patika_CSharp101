using System;
using System.Collections;
using System.Collections.Generic;

namespace Odev2Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 3:
            //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve 
            //dizinin elemanlarını sıralayan programı yazınız.
            Console.Write("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            cumle.ToLower();
            string harf = "aeıioüuü";

            ArrayList sesliHarf = new ArrayList();

            foreach (char item in cumle)
            {
                if (harf.Contains(item))
                {
                    sesliHarf.Add(item);
                }
            }

            sesliHarf.Sort();

            foreach (char item in sesliHarf)
            {
                Console.WriteLine(item);
            }
        
        

        }
    }
}
