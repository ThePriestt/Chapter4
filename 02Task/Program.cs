using System;

// Напишете програма, която чете от конзолата радиуса "r" на кръг и отпечатва неговия периметър, обиколка и лице.

class Program
{
    static void Main()
    {
        double r;

        r = double.Parse(Console.ReadLine());
        Console.WriteLine(2 * Math.PI * r);
        Console.WriteLine(Math.PI * r * r);
    }
}

