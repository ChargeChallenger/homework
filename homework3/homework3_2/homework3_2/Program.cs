using System;
using System.Collections.Generic;

namespace homework3_2
{
    class Program
    {
        static public string[] MenuStrings =
        {
            "1 - Вывод списка",
            "2 - Добавление элемента",
            "3 - Поиск элемента по номеру",
            "4 - Выход"
        };
        static public void PrintMenu()
        {
            Console.Clear();
            foreach (var menuString in MenuStrings)
            {
                Console.WriteLine(menuString);
            }
            Console.WriteLine("Нажмите цифру, соответствующую номеру меню.");
        }
        static public void PrintList(Dictionary<string, string> list)
        {
            Console.Clear();
            if (list.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                foreach (KeyValuePair<string, string> keyValue in list)
                {
                    Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                }
            }
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static public string GetElemExt()
        {
            Console.Clear();
            Console.Write("Введите расширение файла: ");
            string name = Console.ReadLine();
            while (name.Trim() == "")
            {
                Console.Write("Попробуйте снова ввести: ");
                name = Console.ReadLine();
            }
            return name;
        }
        static public string GetElemTranscript()
        {
            Console.Clear();
            Console.Write("Введите расшифровку расширения: ");
            string name = Console.ReadLine();
            while (name.Trim() == "")
            {
                Console.Write("Попробуйте снова ввести: ");
                name = Console.ReadLine();
            }
            return name;
        }
        static public void FindElemByIndex(Dictionary<string, string> list)
        {
            Console.Clear();
            if (list.Count == 0)
            {
                Console.WriteLine("Список пуст. Искать нечего.");
            }
            else
            {
                Console.Write("Введите ключ элемента, который желаете найти: ");
                string findElemExt = Console.ReadLine();
                string result = "";
                try
                {
                    result = list[findElemExt];
                    Console.WriteLine($"Результат: {result}");
                }
                catch
                {
                    Console.WriteLine("Введен отсутствующий ключ");
                }
            }
            Console.WriteLine("Для перехода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> names = new Dictionary<string, string>()
            {
                [".png"] = "portable network graphics",
                [".txt"] = "text",
                [".jpeg"] = "joint photographic experts group",
                [".docx"] = "document",
                [".exe"] = "executable"
            };
            ConsoleKey key = ConsoleKey.Enter;
            do
            {
                PrintMenu();
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        PrintList(names);
                        break;
                    case ConsoleKey.D2:
                        string ext = GetElemExt();
                        string transc = GetElemTranscript();
                        names.Add(ext, transc);
                        break;
                    case ConsoleKey.D3:
                        FindElemByIndex(names);
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D4);
            Console.WriteLine("\nУдачи!");
        }
    }
}
