using System;

// Напишете програма, която отпечатва на конзолата първите 100 числа от редицата на Фибоначи: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, ...

class Program
{
    static void Main(string[] args)
    {
        ulong a = 0;
        ulong b = 1;
        ulong fib;

        for (int i = 0; i <= 100; i++)
        {
            fib = a + b;
            Console.WriteLine(fib);
            
            a = b;
            b = fib;           
        }
    }
}

