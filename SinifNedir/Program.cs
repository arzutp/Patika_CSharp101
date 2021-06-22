using System;

namespace SınıfNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Çalışan 1-------");
            Calisan c1 = new Calisan("Ayse","Kara",322322,"İnsan Kaynakları");
            c1.CalisanBilgi();

            Console.WriteLine("---------Çalışan 2-------");
            Calisan c2 = new Calisan();
            c2.Ad = "Deniz";
            c2.Soyad = "Ay";
            c2.No = 0580490;
            c2.Departman = "Pazarlama";
            c2.CalisanBilgi();

            Console.WriteLine("---------Çalışan 3-------");
            Calisan c3 = new Calisan("Su","Derin");
            c3.CalisanBilgi();


        }
    }
    class Calisan{
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        
        public Calisan(){

        }
        public Calisan(string ad, string soyad, int no, string departman){
            Ad = ad;
            Soyad = soyad;
            No = no;
            Departman = departman;
        }

        public Calisan(string ad, string soyad){
            Ad = ad;
            Soyad = soyad;
        }
        public void CalisanBilgi(){
            Console.WriteLine("Calışanın Adı: {0}", Ad);
            Console.WriteLine("Calışanın Soyadı: {0}", Soyad);
            Console.WriteLine("Calışanın Numarası: {0}", No);
            Console.WriteLine("Calışanın Departmanı: {0}", Departman);
        }

    }
}
