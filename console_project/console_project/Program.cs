using System;
using System.Collections.Generic;

namespace console_project
{
    class Program
    {
        public static List<Manufacturer> manufacturers = new List<Manufacturer>();
        public static List<Laptop> laptops = new List<Laptop>();
        static public string[] SortListLaptop =
        {
            "1 - Сортировка в алфавитном порядке (A-Z)",
            "2 - Сортировка в обратном алфавитном порядке (Z-A)",
            "3 - Сортировка по производителю (A-Z)",
            "4 - Сортировка по производителю (Z-A)",
            "5 - Сортировка по цене (возрастание)",
            "6 - Сортировка по цене (убывание)",
            "7 - В наличии"
        };
        static public string[] SortListManufacturer =
        {
            "1 - Сортировка в алфавитном порядке (A-Z)",
            "2 - Сортировка в обратном алфавитном порядке (Z-A)"
        };
        static public string[] Entering =
        {
            "1 - Покупатель",
            "2 - Администратор",
            "3 - Выход"
        };
        static public string[] MenuStringsClient =
        {
            "1 - Просмотр товаров",
            "2 - Назад"
        };
        static public string[] MenuStringsAdmin =
        {
            "1 - Добавить производителя",
            "2 - Добавить товар",
            "3 - Удалить производителя",
            "4 - Удалить товар",
            "5 - Изменить количество товара",
            "6 - Назад"
        };
        public void PrintListLaptop(List<Laptop> laptops)
        {

        }
        public void PrintListManufacturer(List<Manufacturer> manufacturers)
        {
            ConsoleKey key;
            do
            {
                PrintMenu(MenuStringsClient);
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        break;
                }
            } while (key != ConsoleKey.D2);
        }
        static public void PrintMenu(string[] MenuStrings)
        {
            Console.Clear();
            foreach (var menuString in MenuStrings)
            {
                Console.WriteLine(menuString);
            }
            Console.WriteLine("Нажмите цифру, соответствующую номеру меню.");
        }
        static public void ClientMenu()
        {
            ConsoleKey key;
            do
            {
                PrintMenu(MenuStringsClient);
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        break;
                }
            } while (key != ConsoleKey.D2);
        }
        static public void AdminMenu()
        {
            ConsoleKey key;
            do
            {
                PrintMenu(MenuStringsAdmin);
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.D5:
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D6);
        }
        static void Main(string[] args)
        {
            ConsoleKey key;
            do
            {
                PrintMenu(Entering);
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        ClientMenu();
                        break;
                    case ConsoleKey.D2:
                        AdminMenu();
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D3);
            Console.WriteLine("Удачи!");
        }
    }
}
