using System;

// Напишете програма, която чете пет числа и отпечатва тяхната сума. При невалидно въведено число да се подкани потребителя да въведе друго число.

class Program
{
    static void Main()
    {
        int a;
        int b;
        int c;
        int d;
        int e;

        bool isInt = false; 

        do
        {
            Console.WriteLine("Моля въведете а");
            isInt = int.TryParse(Console.ReadLine(), out a);
        } while (!isInt);

        do
        {
            Console.WriteLine("Моля въведете b");
            isInt = int.TryParse(Console.ReadLine(), out b);
        } while (!isInt);

        do
        {
            Console.WriteLine("Моля въведете c");
            isInt = int.TryParse(Console.ReadLine(), out c);
        } while (!isInt);

        do
        {
            Console.WriteLine("Моля въведете d");
            isInt = int.TryParse(Console.ReadLine(), out d);
        } while (!isInt);

        do
        {
            Console.WriteLine("Моля въведете e");
            isInt = int.TryParse(Console.ReadLine(), out e);
        } while (!isInt);

        Console.WriteLine(a + b + c + d + e);
    }
}
