

// Задача 2: 
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.




using System;

class Program
{
    static void Main()
    {
        string originalString = "Hello WoRlD";
        string lowercaseString = ConvertToUpperToLower(originalString);

        Console.WriteLine("Исходная строка: " + originalString);
        Console.WriteLine("Строка с заменой на строчные буквы: " + lowercaseString);
    }

    static string ConvertToUpperToLower(string input)
    {
        char[] charArray = input.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsUpper(charArray[i]))
            {
                charArray[i] = char.ToLower(charArray[i]);
            }
        }

        return new string(charArray);
    }
}