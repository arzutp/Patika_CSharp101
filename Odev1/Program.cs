using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Soru
            /* Bir konsol uygulamasında kullanıcıdan pozitif bir 
            sayı girmesini isteyin(n). Sonrasında kullanıcıdan 
            n adet pozitif sayı girmesini isteyin. Kullanıcının
             girmiş olduğu sayılardan çift olanlar console'a yazdırın.*/
        
        /*
            Console.WriteLine("Pozitif bir sayi giriniz: ");
            int num = int.Parse(Console.ReadLine());
            int[] numbers = new int[num];
            Console.WriteLine(num + "tane sayı giriniz");
            for(int i=0;i<num;i++){
                int n = int.Parse(Console.ReadLine());
                numbers[i] = n;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i]%2==0){
                    Console.WriteLine(numbers[i] + " çift sayıdır");
                }
            }

        */


        //Soru 2
        /*Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
        Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın. */
        /*
            Console.WriteLine("Pozitif bir sayi giriniz: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Pozitif bir sayi giriniz: ");
            int m = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            Console.WriteLine(n + "tane sayı giriniz");
            for(int i=0;i<n;i++){
                int num = int.Parse(Console.ReadLine());
                numbers[i] = num;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i]%m==0){
                    Console.WriteLine(numbers[i] + " tam bölünür");
                }
            }
        */

        //Soru 3
        /* Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
         Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
        Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın. */
        /*
            Console.WriteLine("Pozitif bir sayi giriniz: ");
            int n = int.Parse(Console.ReadLine());
            string[] words = new string[n];
            Console.WriteLine( n + " adet kelime giriniz");
            for (int i = 0; i < n; i++)
            {
                words[i] = Console.ReadLine();
            }
            for (int i = n-1; i >= 0; i--)
            {

                Console.WriteLine(words[i]);

            }

        */


        //Soru 4
        /* Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
        Cümledeki toplam kelime ve harf sayısını console'a yazdırın. */

        /*
            Console.Write("Bir cümle giriniz: ");
            string Sentence = Console.ReadLine();
            string[] NumberofWord = Sentence.Split(" ");
            
            int NumberofCharacter = Sentence.Length;
            NumberofCharacter = NumberofCharacter - (NumberofWord.Length-1);

            Console.WriteLine("Kelime Sayisi: " + NumberofWord.Length);
            Console.WriteLine("Harf Sayisi: " + NumberofCharacter);

        */
        }

        
    }
}
