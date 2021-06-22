using System;

namespace StaticSinif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);
            Calisan c1 = new Calisan("Deniz","Ay","IK");
            Console.WriteLine("Çalışan sayısı: {0}",Calisan.CalisanSayisi);
            Calisan c2 = new Calisan("Ayşe","Ege","Pazarlama");
            Calisan c3 = new Calisan("Su","Gider","CEO");
        
            Console.WriteLine(Islemler.Topla(100,200));
            Console.WriteLine(Islemler.Cıkar(900,200));

        }
    }

    class Calisan{
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi; }

        private string isim;
        private string soyisim;
        private string departman;

        static Calisan(){
            calisanSayisi = 0;
        }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;
            calisanSayisi ++;
        }
    }

    static class Islemler{
        public static long Topla(int sayi1 , int sayi2){
            return sayi1 + sayi2;
        }

        public static long Cıkar(int sayi1 , int sayi2){
            return sayi1 - sayi2;
        }
    }
}
