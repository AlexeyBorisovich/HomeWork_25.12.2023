// Задача 1: 
// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.


using System;

class Program
{
    static void Main()
    {
        char[,] charArray = {
            { 'Q', 'W', 'E' },
            { 'A', 'S', 'D' },
            { 'Z', 'X', 'C' }
        };

        string resultString = ArrayToString(charArray);

        Console.WriteLine("Исходный двумерный массив символов:");
        PrintCharArray(charArray);

        Console.WriteLine("\nСтрока из символов массива:");
        Console.WriteLine(resultString);
    }

    static string ArrayToString(char[,] charArray)
    {
        int rows = charArray.GetLength(0);
        int cols = charArray.GetLength(1);

        char[] resultArray = new char[rows * cols];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultArray[index] = charArray[i, j];
                index++;
            }
        }

        return new string(resultArray);
    }

    static void PrintCharArray(char[,] charArray)
    {
        int rows = charArray.GetLength(0);
        int cols = charArray.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(charArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}