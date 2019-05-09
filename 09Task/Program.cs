using System;

// Напишете програма, която чете коефициентите a, b и c от конзолата и решава уравнението: ax2+bx+c=0. 
// Програмата трябва да принтира реалните решения на уравнението на конзолата.

class Program
{
    static void Main()
    {
        int a;
        int b;
        int c;

        Console.WriteLine("Моля въведете а: ");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Моля въведете b: ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Моля въведете c: ");
        c = int.Parse(Console.ReadLine());

        Console.WriteLine((-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a);
        Console.WriteLine((-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a);
    }
}

