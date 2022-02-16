using System;
using System.Collections.Generic;

namespace AuctionSite
{
    class Program
    {
        public static void displayItems(List<string[]> items)
        {
            Console.WriteLine("LISTA PRZEDMIOTÓW NA AUKCJI");
            Console.WriteLine("\n------------------------------------\n");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + items[i][0] + " | " + items[i][1] + " | " + items[i][2] + " PLN");
            }
        }

        public static void buy(List<string[]> items)
        {
            displayItems(items);

            Console.Write("PODAJ NUMER PRODUKTU KTÓRY CHCESZ ZAKUPIĆ:");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("PODAJ NUMER KARTY KREDYTOWEJ (CZTERY CYFRY):");
            int credit_card_no = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Kupiłeś przedmiot: " + items[choice - 1][0]);
            Console.WriteLine("Cena: " + items[choice - 1][2] + " EUR");
            Console.WriteLine("Płatność kartą: Mastercard (nr karty: " + credit_card_no + ")");

        }

        public static void sell(List<string[]> items)
        {
            Console.Write("PODAJ NAZWĘ PRZEDMIOTU, KTÓRY CHCESZ SPRZEDAĆ:");
            string item_name = Console.ReadLine();
            Console.Clear();

            Console.Write("PODAJ KATEGORIĘ PRZEDMIOTU, DO KTÓREJ NALEŻY PRODUKT:");
            string item_category = Console.ReadLine();
            Console.Clear();

            Console.Write("PODAJ CENĘ PRZEDMIOTU, KTÓRĄ CHCESZ OTRZYMAĆ:");
            string price = Console.ReadLine();
            Console.Clear();

            Console.Write("NAPISZ tak JEŻELI PRZEDMIOT MA BYĆ PROMOWANY:");
            string promoted = Console.ReadLine();
            Console.Clear();

            items.Add(new string[] { item_name, item_category, price });
            displayItems(items);
        }

        public static void Main(string[] args)
        {
            List<string[]> items = new List<string[]> {
                new string[] { "Bluza Adidas Męska Szara", "odzież", "249" },
                new string[] { "iPhone 12 Pro", "elektronika", "4600" },
                new string[] { "Basen ogrodowy Premium", "dom i ogród", "1199" },
                new string[] { "Konsola Playstation 5", "elektronika", "2899" },
                new string[] { "Krzesło skandynwskie granatowe", "dom i ogród", "88" },
                new string[] { "Spodnie Wrangler Arizona", "odzież", "189" }
            };
            Console.Clear();
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => ZAKUP");
            Console.WriteLine("2 => SPRZEDAŻ");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.Write("WYBIERZ 1, 2 LUB 3:");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    buy(items);
                    break;
                case 2:
                    Console.Clear();
                    sell(items);
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
    }
}