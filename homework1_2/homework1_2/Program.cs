using System;

namespace homework1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, counter = 1;
            char temp;
            while (counter <= 10)
            {
                Console.WriteLine("Введите направление движения (С, Ю, В, З): ");
                temp = char.Parse(Console.ReadLine());
                switch(temp)
                {
                    case 'С':
                    case 'с':
                        x += 1;
                        Console.WriteLine($"Шаг {counter}: Вы сходили на Север.");
                        counter += 1;
                        break;
                    case 'Ю':
                    case 'ю':
                        x -= 1;
                        Console.WriteLine($"Шаг {counter}: Вы сходили на Юг.");
                        counter += 1;
                        break;
                    case 'В':
                    case 'в':
                        y -= 1;
                        Console.WriteLine($"Шаг {counter}: Вы сходили на Восток.");
                        counter += 1;
                        break;
                    case 'З':
                    case 'з':
                        y += 1;
                        Console.WriteLine($"Шаг {counter}: Вы сходили на Запад.");
                        counter += 1;
                        break;
                    default:
                        Console.WriteLine("Такого направления нет!");
                        break;
                }
            }
            double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine($"Вы прошли {result} метра/ов.");
        }
    }
}
