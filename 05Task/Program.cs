using System;

// Напишете програма, която чете от конзолата две цели числа (int) и отпечатва, колко числа има между тях, такива, че остатъкът им от деленето на 5 да е 0. 
// Пример: в интервала (17, 25) има 2 такива числа.

class Program
{
    static void Main()
    {
        int a;
        int b;

        Console.Write("Моля въведете първото число: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Моля въведете второто число: ");
        b = int.Parse(Console.ReadLine());

        for (int i = a ; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}

