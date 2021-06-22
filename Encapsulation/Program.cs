using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //kapsülleme bir nesnenin methodlarını diğer sınıflardan koruma
            Ogrenci o1 = new Ogrenci();
            o1.Ad = "Ayşe";
            o1.Soyad = "Yılmaz";
            o1.No = 98;
            o1.Sinif = 4;
            o1.OgrenciBilgileri();

            o1.SinifAtlat();
            o1.OgrenciBilgileri();

            Ogrenci o2 = new Ogrenci("Deniz", "Ay", 566,-1);
            o2.SinifDusur();
            o2.OgrenciBilgileri();

        }
    }

    class Ogrenci{
        private string ad;
        private string soyad;
        private int no;
        private int sinif;

        public string Ad { 
            get{
                return ad;
            }
            set {
                ad = value;
                } 
            }
        public string Soyad { get => soyad; set => soyad = value; }
        public int No { get => no; set => no = value; }
        public int Sinif { 
            get => sinif; 
            set{ 
                if(value < 1){
                    Console.WriteLine("Sınıf en az 1 olmalıdır");
                    sinif = 1; 
                }
                else
                
                    sinif = value;
            }          

        }

        public Ogrenci(string ad, string soyad, int no, int sinif)
        {
            Ad = ad;
            Soyad = soyad;
            No = no;
            Sinif = sinif;
        }

        public Ogrenci(){}

        public void OgrenciBilgileri(){
            Console.WriteLine("-------Öğrenci Bilgileri----------");
            Console.WriteLine("Öğrenci Adı: {0}",this.Ad);
            Console.WriteLine("Öğrenci Soyadı: {0}",this.Soyad);
            Console.WriteLine("Öğrenci No: {0}",this.No);
            Console.WriteLine("Öğrenci Sınıfı: {0}",this.Sinif);
        }

        public void SinifAtlat(){
            this.Sinif = this.Sinif+1;
        }

        public void SinifDusur(){
            this.Sinif = this.Sinif-1;
        }


    }
}
