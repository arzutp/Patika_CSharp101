using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyon3_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            //list.Add("Ayse");
            list.Add(3);
            //list.Add(true);
            //list.Add("A");

           // Console.WriteLine(list[1]);
            foreach (var item in list)
            {
                Console.WriteLine(item);   
            }

            //AddRange birden fazla eleman
            Console.WriteLine("---------AddRange------------");
            string[] renkler = {"kırmızı" , "sarı" , "mor"};
            //list.AddRange(renkler);
            List<int> sayilar = new List<int>(){1,4,5,1,55,66,6};
            list.AddRange(sayilar);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------Sort-----------");
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Binary Search
            Console.WriteLine("------Binary Search--------");
            Console.WriteLine(list.BinarySearch(3));


            //Reverse
            Console.WriteLine("-----------Reverse------------");
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            //clear
            Console.WriteLine("------------Clear------------");
            list.Clear();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
