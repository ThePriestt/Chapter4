using System;

// Напишете програма, която чете от конзолата три числа от тип int и отпечатва тяхната сума.

class Program
{
    static void Main()
    {
        int a;
        int b;
        int c;
        
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());

        Console.WriteLine(a + b + c);
    }
}

