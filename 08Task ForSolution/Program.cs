using System;

// Напишете програма, която чете пет числа от конзолата и отпечатва най-голямото от тях.

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        int max = int.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Please enter number {0}", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
            if (max < numbers[i])
            {
                max = numbers[i];
            }
        }

        

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    if (max < numbers[i])
        //    {
        //        max = numbers[i];
        //    }
        //}
        Console.WriteLine(max);
    }
}

