
// Задача 3: 
// Задайте произвольную строку. 
// Выясните, является ли она палиндромом.


using System;

class Program
{
    static void Main()
    {
        string inputString = "Шалаш";

        bool isPalindrome = IsPalindrome(inputString);

        if (isPalindrome)
            Console.WriteLine("Строка является палиндромом.");
        else
            Console.WriteLine("Строка не является палиндромом.");

        Console.ReadLine();
    }

    static bool IsPalindrome(string str)
    {
        string cleanStr = str.Replace(" ", "").ToLower();

        for (int i = 0; i < cleanStr.Length / 2; i++)
        {
            if (cleanStr[i] != cleanStr[cleanStr.Length - 1 - i])
                return false;
        }

        return true;
    }
}