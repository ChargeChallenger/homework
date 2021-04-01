using System;
using System.Linq;
using System.Collections.Generic;

namespace homework3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество минут: ");
            int minutes = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество клиентов: ");
            int arraySize = int.Parse(Console.ReadLine());
            List<int> array = new List<int>();
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Введите сколько нужно минут обслуживания клиенту номер {i+1}:");
                int client_minutes = int.Parse(Console.ReadLine());
                if (minutes > 0)
                {
                    minutes -= client_minutes;
                    array.Add(client_minutes);
                }
            }
            Console.WriteLine($"Возможно обслужить клиентов: {array.Count}");
        }
    }
}
