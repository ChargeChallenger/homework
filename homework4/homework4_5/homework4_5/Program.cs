using System;
using System.Collections.Generic;
using System.Linq;

namespace homework4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Random generator = new Random();
            for (int i=0; i <50; i++)
            {
                numbers.Add(generator.Next(0, 50));
            }
            var resultNumbers = numbers.Distinct();
            resultNumbers = resultNumbers.OrderByDescending(resultNumber => resultNumber);
            resultNumbers = resultNumbers.Where(resultNumber => resultNumber >= 10);
            resultNumbers = resultNumbers.Where(resultNumber => resultNumber <= 20);
            foreach (int i in resultNumbers)
            {
                 Console.WriteLine(i);
            }
        }
    }
}
