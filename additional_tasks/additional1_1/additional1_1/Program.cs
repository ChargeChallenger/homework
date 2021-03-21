using System;

namespace additional1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число:");
            int number = int.Parse(Console.ReadLine());
            if ((number - 4) % 4 == 0)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            };
        }
    }
}
