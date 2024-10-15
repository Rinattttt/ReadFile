using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\Alena\\Desktop\\24_demo.txt"; 
        try
        {
            string content = File.ReadAllText(filePath);
            int maxLength = FindLongestXSequence(content);
            Console.WriteLine($"Длина самой длинной последовательности символов 'X': {maxLength}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }

    static int FindLongestXSequence(string str)
    {
        int maxCount = 0; // Максимальная длина последовательности
        int currentCount = 0; // Длина текущей последовательности

        foreach (char c in str)
        {
            if (c == 'X')
            {
                currentCount++;
            }
            else
            {
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
                currentCount = 0; // Сбрасываем счетчик
            }
        }

        // Проверяем последнюю последовательность
        if (currentCount > maxCount)
        {
            maxCount = currentCount;
        }

        return maxCount;
    }
}