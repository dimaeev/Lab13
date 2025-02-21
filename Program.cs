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
    }
}