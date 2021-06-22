using System;

namespace StructYapilar
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen d = new Dikdortgen();
            d.KisaKenar = 3;
            d.UzunKenar = 6;
            Console.WriteLine("Class alan hesabı: {0}",d.AlanHesapla());

            Dikdortgen_Struct dS = new Dikdortgen_Struct();
            dS.KisaKenar = 4;
            dS.UzunKenar = 5;
            Console.WriteLine("Struct ile alan hesalama: {0}",dS.AlanHesapla());

            Dikdortgen_Struct dikS;
            dikS.KisaKenar = 2;
            dikS.UzunKenar = 3;
            Console.WriteLine("Struct ile alan hesalama: {0}",dikS.AlanHesapla());
        
            Dikdortgen_Struct str = new Dikdortgen_Struct(2,5);
            Console.WriteLine("Struct ile alan hesalama: {0}",str.AlanHesapla());

            
        }
    }

    class Dikdortgen{
        public int KisaKenar;
        public int UzunKenar;
        public long AlanHesapla(){
            return this.KisaKenar * this.UzunKenar;
        }
    }

    struct Dikdortgen_Struct{
        public int KisaKenar;
        public int UzunKenar;
        public long AlanHesapla(){
            return this.KisaKenar * this.UzunKenar;
        }

        public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }
    }
}
