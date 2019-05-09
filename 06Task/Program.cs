using System;

// Напишете програма, която чете две числа от конзолата и отпечатва по-голямото от тях. Решете задачата без да използвате условни конструкции.

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

        Console.WriteLine(Math.Max(a, b));
        Console.WriteLine(Math.Min(a, b));
    }
}

