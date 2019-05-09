using System;

// Напишете програма, която прочита едно цяло число n от конзолата. След това прочита още n на брой числа от конзолата и отпечатва тяхната сума.

class Program
{
    static void Main()
    {
        Console.WriteLine("Моля въведете n");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Please enter element {0}", i);
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}

