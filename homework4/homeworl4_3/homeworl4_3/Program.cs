using System;
using System.Collections.Generic;
using System.Linq;

namespace homeworl4_3
{
    class Program
    {
        static int Max(List<int> numbersList)
        {
            var sortList = numbersList.OrderByDescending(number => number);
            return sortList.First();
        }
        static int Min(List<int> numbersList)
        {
            var sortList = numbersList.OrderBy(number => number);
            return sortList.First();
        }
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
            int maxNumber = Max(numbers);
            int minNumber = Min(numbers);
            Console.WriteLine($"Max: {maxNumber}, Min: {minNumber}");
        }
    }
}
