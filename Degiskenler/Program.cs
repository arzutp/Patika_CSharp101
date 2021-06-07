using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;     //bellekte 1 byte yer kaplar 0 ile 255 arası değerler
            sbyte c = 4;    //1 byte yer kaplar -128 ile 127 arası değerleri alır

            short s = 5;    //2 byte yer kaplar -32768  ile 32768 arası tam sayı değerler
            ushort us = 5;  //2 byte 0 ile 65365 arası

            Int16 i16 = 2;  //2 byte yer kaplar 
            int i = 2;      //4 byte yer kaplar baya baya büyük değer aralığı :)
            Int32 i32 = 2;  //4 byte 
            Int64 i64 = 2;  //8 byte yer kaplar

            uint ui = 2;    //4 byte
            long l = 4;     //8 byte
            ulong ul = 4;   //8 byte

            float f = 4;    //4 byte yer 
            double d = 3.4; //8 byte yer kaplar
            decimal de = 5; //16 byte

            //string ifadeler
            char ch = 'a';  //tek karakter 2 byte
            string str = "aaa"; //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            //string ifadeler
            string str1 = string.Empty;
            str1 = "dsd sdfd";
            string ad = "Arzu";
            string soyad = "Tepe";
            string tamIsim = ad + " " + soyad;

            //integer tanımlama şekilleri
            int int1 = 4;
            int int2 = 5;
            int integer = int1 * int2;

            bool bo = 10>2;

            //Değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            System.Console.WriteLine(yeniDeger);  //çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            System.Console.WriteLine(int21);  //çıktısı 40

            int int22 = int20 + int.Parse(str20);  //çıktısı 40


            //datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            System.Console.WriteLine(datetime);

            string datetime1 = DateTime.Now.ToString("dd/MM/yyyy");
            System.Console.WriteLine(datetime);

            string hour = DateTime.Now.ToString("HH:mm");
            System.Console.WriteLine(datetime);

        }
    }
}
