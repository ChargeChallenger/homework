using System;

namespace additional1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] thousands = { "", "M", "MM", "MMM", "MMMM" };

            Console.WriteLine("Введите число (от 0 до 4000):");
            int number = int.Parse(Console.ReadLine());

            string result = thousands[number / 1000];
            result += hundreds[number / 100 % 10];
            result += tens[number / 10 % 10];
            result += ones[number % 10];

            Console.WriteLine(result);
        }
    }
}
