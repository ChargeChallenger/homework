using System;
using System.Globalization;

namespace homework2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива:");
            int arraySize = int.Parse(Console.ReadLine());
            int[,] squareArray = new int[arraySize, arraySize];
            for (int columnIteration = 0; columnIteration < arraySize; columnIteration++)
            {
                for (int rowIteration = 0; rowIteration < arraySize; rowIteration++)
                {
                    Console.WriteLine($"Впишите {columnIteration + 1},{rowIteration + 1} элемент массива:");
                    squareArray[columnIteration, rowIteration] = int.Parse(Console.ReadLine());
                }
            }
            for (int columnIteration = 0; columnIteration < arraySize; columnIteration++) // Сложность O(n2)
            {
                for (int rowIteration = 0; rowIteration < arraySize; rowIteration++)
                {
                    if (squareArray[columnIteration, rowIteration] != squareArray[rowIteration, columnIteration])
                    {
                        goto notSymmetry;
                    }
                }
            }
            goto Symmetry;

        notSymmetry:
            Console.WriteLine("Массив не симметричен");

        Symmetry:
            Console.WriteLine("Массив симметричен");
        }
    }
}
