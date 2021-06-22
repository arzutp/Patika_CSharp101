using System;
using System.Collections;
using System.Collections.Generic;

namespace Proje1
{
    class Program
    {
        
        public static List<Person> persons;
        static void Main(string[] args)
        {
            
            persons = new List<Person>();
            persons.Add(new Person("Kapı", "Kolu", "2222222222"));
            persons.Add(new Person("Halin", "Hatrın", "7777777777"));
            persons.Add(new Person("Kitap","Kapağı","3333333333333"));
            persons.Add(new Person("Aslı","Gibidir","43224253523"));
            persons.Add(new Person("Şekersiz","Kahve","972938729"));
            

            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:)");
            Console.WriteLine("******************************************");
            Console.WriteLine("(1) Yeni Numara Eklemek\n(2) Varolan Numarayı Silmek\n(3) Varolan Numarayı Güncellemek\n(4) Rehberi Listelemek\n(5) Rehberde Arama Yapmak\n");
            Console.Write("İşlem tercihiniz: ");

            int temp = int.Parse(Console.ReadLine());

            switch (temp)
            {
                case 1:
                    AddNumber();
                    break;
                case 2:
                    DeleteNumber();
                    break;
                case 3:
                    UpdateNumber();
                    break;
                case 4:
                    ListNumber();
                    break;
                case 5:
                    SearchNumber();
                    break;
                default:
                    break;
            }
        
        }

        public static void AddNumber(){
             Console.WriteLine("Lütfen isim giriniz             : ");
             string name = Console.ReadLine();
             Console.WriteLine("Lütfen soyisim giriniz          : ");
             string surname = Console.ReadLine();
             Console.WriteLine("Lütfen telefon numarası giriniz : ");
             string num = Console.ReadLine();

             Person person = new Person(name, surname, num);
             persons.Add(person);
             Menu();

        }

        public static void DeleteNumber(){

            Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string person = Console.ReadLine();
            foreach (Person item in persons)
            {
                if(item.Name == person || item.Surname == person){
                    Console.WriteLine(" {} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                    string t = Console.ReadLine();
                    if(t == "y"){
                        persons.Remove(item);
                        Console.WriteLine("işlem başarılı ");
                        Menu();
                    }
                    else if(t == "n"){
                        Console.WriteLine("Numara silinmedi");
                        Menu();
                    }
                    else{
                        Console.WriteLine("Hatalı giriş yaptınız");
                        DeleteNumber();
                    }
                }
            }
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine(" * Silmeyi sonlandırmak için : (1)\n* Yeniden denemek için      : (2)");
            int temp = int.Parse(Console.ReadLine());
            if(temp==1)
                Menu();
            else if(temp == 2)
                DeleteNumber();
            else{
                Console.WriteLine("Hatalı giriş yaptınız");
                Menu();
            }

        }

        public static void UpdateNumber(){
            Console.WriteLine(" Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string person = Console.ReadLine();
            foreach (Person item in persons)
            {
                Console.Write("{0} {1} isimli kişinin yeni numarasını giriniz: ", item.Name, item.Surname);
                string newNumber = Console.ReadLine();
                item.PhoneNumber = newNumber;
                Menu();
                
            }
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine(" * Güncellemeyi sonlandırmak için : (1)\n* Yeniden denemek için      : (2)");
            int temp = int.Parse(Console.ReadLine());
            if(temp==1)
                Menu();
            else if(temp == 2)
                UpdateNumber();
            else{
                Console.WriteLine("Hatalı giriş yaptınız");
                Menu();
            }

        }

        public static void ListNumber(){
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach (Person item in persons)
            {
                Console.WriteLine("isim: {0}",item.Name);
                Console.WriteLine("Soyisim: {0}",item.Surname);
                Console.WriteLine("Telefon Numarası: {0}",item.PhoneNumber);
                Console.WriteLine("-");
            }
            Menu();
        }

        public static void SearchNumber()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("*********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için : (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için : (2)");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("İsim veya soyisim giriniz: ");
                string personName = Console.ReadLine();

                foreach (Person item in persons)
                {
                    if (item.Name == personName || item.Surname == personName)
                    {
                        Console.WriteLine("isim: {0}",item.Name);
                        Console.WriteLine("Soyisim: {0}",item.Surname);
                        Console.WriteLine("Telefon Numarası: {0}",item.PhoneNumber);
                        
                    }
                }

                Menu();
            }
            else if (choice == "2")
            {
                Console.Write("Telefon numarası giriniz: ");
                string phoneNumber = Console.ReadLine();

                foreach (Person item in persons)
                {
                    if (item.PhoneNumber == phoneNumber)
                    {
                        Console.WriteLine("isim: {0}",item.Name);
                        Console.WriteLine("Soyisim: {0}",item.Surname);
                        Console.WriteLine("Telefon Numarası: {0}",item.PhoneNumber);
                    }
                }

                Menu();
            }
            else
            {
                Console.WriteLine("Hatalı Giriş Yaptınız!\n Tekrar Deneyiniz");
                SearchNumber();
            }
        }

    }
    
}