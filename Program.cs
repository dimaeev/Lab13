using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Programm
{
    static void Main()
    {
        Console.Write("Введите число a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите степень n: ");
        int n = int.Parse(Console.ReadLine());

        int result = 1;

        for (int i = 0; i < n; i++)
        {
            result *= a;
        }
        
        Console.WriteLine($"Результат: {result}");

        
        Console.Write("Введите число x (x >= 100): ");
        int x = int.Parse(Console.ReadLine());

        if (x < 100)
        {
            Console.WriteLine("Число должно быть больше или равно 100");
            return;
        }

        string xString = x.ToString();

        char secondDigit = xString[1];

        string nString = xString.Remove(1, 1) + secondDigit;

        Console.WriteLine($"Полученное число n: {nString}");
    }
}