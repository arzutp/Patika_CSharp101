using System;
using System.Collections.Generic;

namespace Proje2
{
    class Program
    {
        
        public static List<Card> cards;
        public static IDictionary<int, string> employeeList;
        static void Main(string[] args)
        {
            employeeList = new Dictionary<int, string>();
            employeeList.Add(0, "Kapı Kapalı");
            employeeList.Add(1, "Uzun Kuyruk");
            employeeList.Add(2, "Kuru Kafa");
            employeeList.Add(3, "Can Ciğer");
            employeeList.Add(4, "Kuzu Sarması");

            cards = new List<Card>()
            {
                new Card("Odev", "matematik ödevi", 2, 3, "todo" ),
                new Card("Ödev", "fen ödevi", 1, 1, "IN PROGRESS"),
                new Card("Ödev", "ingilizce ödevi", 3, 4, "DONE")
            };

            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz :");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek \n(2) Board'a Kart Eklemek\n(3) Board'dan Kart Silmek \n(4) Kart Taşımak\n");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    BoardList();
                    break;
                case "2":
                    AddCard();
                    break;
                case "3":
                    RemoveCard();
                    break;
                case "4":
                    MoveCard();
                    break;
                default:
                    Console.WriteLine("Hatalı giriş yaptınız!");
                    Menu();
                    break;
            }
        }

        public static void BoardList()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            foreach (Card item in cards)
            {
                string employee = employeeList[item.Employee];
                Console.WriteLine("Başlık : " + item.Title);
                Console.WriteLine("İçerik : " + item.Description);
                Console.WriteLine("Atanan Kişi : " + employee);
                Console.WriteLine("Büyüklük : " + (Size)item.Size);
                Console.WriteLine("-");
                
            }

            Console.WriteLine("\nIN PROGRESS Line");
            Console.WriteLine("********************************");
            foreach (Card card in cards)
            {
                if (card.Status == "inProgress")
                {
                    string employee = employeeList[card.Employee];
                    Console.WriteLine("Başlık : " + card.Title);
                    Console.WriteLine("İçerik : " + card.Description);
                    Console.WriteLine("Atanan Kişi : " + employee);
                    Console.WriteLine("Büyüklük : " + (Size)card.Size);
                    Console.WriteLine("-");
                }
            }

            Console.WriteLine("\nDONE Line");
            Console.WriteLine("************************");
            foreach (Card card in cards)
            {
                if (card.Status == "inProgress")
                {
                    string employee = employeeList[card.Employee];
                    Console.WriteLine("Başlık : " + card.Title);
                    Console.WriteLine("İçerik : " + card.Description);
                    Console.WriteLine("Atanan Kişi : " + employee);
                    Console.WriteLine("Büyüklük : " + (Size)card.Size);
                    Console.WriteLine("-");
                }
            }

            Menu();
        }

        public static void AddCard()
        {
            Console.WriteLine("\nKart Ekleme");
            Console.WriteLine("****************************");

            Console.Write("Başlık Giriniz: ");
            string title = Console.ReadLine();

            Console.Write("İçerik Giriniz: ");
            string description = Console.ReadLine();

            Console.Write("Büyüklük Seçiniz -> XS(1), S(2), M(3), L(4), XL(5): ");
            int size = int.Parse(Console.ReadLine());
            if (size <= 0 || size > 5)
            {
                Console.WriteLine("Hatalı giriş yaptınız!");
                Menu();
            }

            Console.Write("Kişi Seçiniz: ");
            foreach (var item in employeeList)
            {
                Console.WriteLine("Id {0}, Adı {1}",item.Key,item.Value);
            }
            int ID = int.Parse(Console.ReadLine());
            foreach (KeyValuePair<int, string> employee in employeeList)
            {
                if (employee.Key == ID)
                {
                    cards.Add(new Card(title, description, ID, size, "todo"));
                    Console.WriteLine("Kart başarıyla eklendi!");
                    Menu();
                }
            }

            Console.WriteLine("Hatalı giriş yaptınız!");
            Menu();
        }

        public static void RemoveCard()
        {
            Console.WriteLine("\nÖncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string input = Console.ReadLine();


            int temp = 0;
            for (int i = cards.Count - 1; i >= 0; i--)
            {
                if (cards[i].Title == input)
                {
                    cards.Remove(cards[i]);
                    temp++;
                }
            }

            if (temp > 0)
            {
                Console.WriteLine("Listeden {0} kart başarıyla silindi.", temp);
                Menu();
            }

            Console.WriteLine("Aradığınız kriterlere uygun bir kart bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için : (2)");
            input = Console.ReadLine();

            if (input == "1")
            {
                Menu();
            }
            else if (input == "2")
            {
                RemoveCard();
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız!");
                Menu();
            }
        }

        public static void MoveCard()
        {
            Console.WriteLine("\nÖncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string input = Console.ReadLine();

            foreach (Card card in cards)
            {
                if (input == card.Title)
                {
                    Console.WriteLine("\nBulunan Kart Bilgileri");
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Başlık : ");
                    Console.WriteLine("İçerik : ");
                    Console.WriteLine("Atanan Kişi : ");
                    Console.WriteLine("Büyüklük : ");
                    Console.WriteLine("Line : ");

                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) IN PROGRESS");
                    Console.WriteLine("(3) DONE");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            card.Status = "todo";
                            break;
                        case "2":
                            card.Status = "inProgress";
                            break;
                        case "3":
                            card.Status = "done";
                            break;
                        default:
                            break;
                    }

                    Menu();
                }
            }

            Console.WriteLine("Aradığınız kriterlere uygun bir kart bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Taşımayı sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için : (2)");
            input = Console.ReadLine();

            if (input == "1")
            {
                Menu();
            }
            else if (input == "2")
            {
                RemoveCard();
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız!");
                Menu();
            }

        }
        
    }
}
