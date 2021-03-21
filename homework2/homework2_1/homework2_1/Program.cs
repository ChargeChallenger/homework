using System;
using System.Collections.Generic;

namespace homework2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива:");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Введите {i+1} элемент массива:") ;
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            Console.WriteLine("Массив отсортирован по возрастанию");
            int uniqueCounter = 1; //Предполагается, что в массиве уже есть какое-либо число
            for (int i = 1; i < arraySize; i++)
            {
                if (array[i] != array[i-1])
                {
                    uniqueCounter++;
                }
            }
            Console.WriteLine($"Уникальных чисел: {uniqueCounter}");
        }
    }
}
