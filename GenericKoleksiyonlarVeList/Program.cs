using System;
using System.Collections.Generic;

namespace GenericKoleksiyonlarVeList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //T -> object turundedir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(32);
            sayiListesi.Add(244);
            sayiListesi.Add(340);
            sayiListesi.Add(98);
            sayiListesi.Add(988);
            sayiListesi.Add(4);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");
            renkListesi.Add("bordo");
            renkListesi.Add("siyah");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var item in sayiListesi)
            {
                Console.WriteLine(item);
            }
            foreach (var item in renkListesi)
            {
                Console.WriteLine(item);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));
            

            //listeden eleman çıkarma
            sayiListesi.Remove(244);
            renkListesi.Remove("kırmızı");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));
            
            //index ile çıkarma
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));
            
            //liste içerisinde arama
            if(sayiListesi.Contains(98)){
                Console.WriteLine("98 listede");
            }

            //eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("mavi"));

            //diziyi list'e çevirme
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};

            List<string> hayvan = new List<string>(hayvanlar);

            //listeyi temizleme
            hayvan.Clear();

            //liste içinde nesne tutmak istersek
            List<Kullanıcılar> kullanıcılars = new List<Kullanıcılar>();
            Kullanıcılar k1 = new Kullanıcılar();
            k1.Isim = "Ayse";
            k1.Soyisim = "Yılmaz";
            k1.Yas = 13;
            Kullanıcılar k2 = new Kullanıcılar();
            k2.Isim = "Ahmet";
            k2.Soyisim = "Sancak";
            k2.Yas = 3;

            kullanıcılars.Add(k1);
            kullanıcılars.Add(k2);

            List<Kullanıcılar> yeni = new List<Kullanıcılar>();
            yeni.Add(new Kullanıcılar(){
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 90
            });

            foreach (Kullanıcılar kullanıcı in kullanıcılars)
            {
                Console.WriteLine(kullanıcı.Isim);
                Console.WriteLine(kullanıcı.Soyisim);
                Console.WriteLine(kullanıcı.Yas);
            }

        }
    }

    public class Kullanıcılar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }

}
