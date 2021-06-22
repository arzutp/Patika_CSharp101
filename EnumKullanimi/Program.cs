using System;

namespace EnumKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 32;
            if(sicaklik<=(int)HavaDurumu.Normal){
                Console.WriteLine("Dışarıya çıkmadan önce güneş kremi kullanın...");
            }
            else if(sicaklik >=(int)HavaDurumu.Sicak){
                Console.WriteLine("Hava çok sıcak");
            }
            else if(sicaklik >=(int)HavaDurumu.Normal && sicaklik <(int)HavaDurumu.Sicak){
                Console.WriteLine("Dışarıya çıkabiliriz");
            }
        }
    }

    enum Gunler{
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu{
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 40
    }
}
