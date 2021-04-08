using System;
using System.Collections.Generic;
using System.Linq;

namespace homework4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество вводимых чисел:");
            int amount = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"Введите {i + 1} число:");
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            var distinctnumbers = numbers.Distinct();
            int result = distinctnumbers.Count();
            Console.WriteLine($"Результат: {result}");
        }
    }
}
