using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //atama ve işlemli atama
            System.Console.WriteLine("Atama işlemleri");
            int x = 3;
            int y = 3;

            y = y + 2;
            System.Console.WriteLine(y);
            y+=2;
            System.Console.WriteLine(y);
            y/=2;
            System.Console.WriteLine(x);
            x *= 2;
            System.Console.WriteLine(x);

            //Mantıksal operatorler
            System.Console.WriteLine("Mantıksal operatorler");
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && true)
                System.Console.WriteLine("Perfect");

            if(isSuccess || isCompleted)
                System.Console.WriteLine("Great");
            
            if(isSuccess && isCompleted)
                System.Console.WriteLine("Fine");

            //ilişkisel operatorler
            System.Console.WriteLine("ilişkisel operatorler");
            int a = 5;
            int b = 4;
            bool sonuc = a<b;
            System.Console.WriteLine(sonuc);

            sonuc = a>b;
            System.Console.WriteLine(sonuc);


            System.Console.WriteLine("Aritmetik operatorler");
            int sayi = 10;
            int sayi2 = 5;
            int sonuc1 = sayi/sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi*sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi+sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi-sayi2;
            Console.WriteLine(sonuc1);

            //mod işlemi %
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);

        }
    }
}
