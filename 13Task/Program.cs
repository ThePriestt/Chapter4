using System;

// Напишете програма, която пресмята сумата (с точност до 0.001):1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

class Program
{
    static void Main()
    {
        decimal sum = 0;
        decimal oldsum = sum;

        for (int i = 1; true; i++)
        {
            sum = sum + 1.0m / i;
            if (sum - oldsum < 0.001m)
            {
                break;
            }
            oldsum = sum;
        }
        Console.WriteLine(sum);
    }
}

