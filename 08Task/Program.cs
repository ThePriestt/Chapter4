using System;

// Напишете програма, която чете пет числа от конзолата и отпечатва най-голямото от тях.

class Program
{
    static void Main()
    {
        int a;
        int b;
        int c;
        int d;
        int e;
                                    
        Console.WriteLine("Моля въведете a");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Моля въведете b");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Моля въведете c");
        c = int.Parse(Console.ReadLine());

        Console.WriteLine("Моля въведете d");
        d = int.Parse(Console.ReadLine());

        Console.WriteLine("Моля въведете e");
        e = int.Parse(Console.ReadLine());

        if (a < b)
        {
            if (c < b)
            {
                if (d < b)
                {
                    if (e < b)
                    {
                        Console.WriteLine(b);
                    }
                    else
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    if (e < d)
                    {
                        Console.WriteLine(d);
                    }
                    else
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            else
            {
                if (d < c)
                {
                    if (e < c)
                    {
                        Console.WriteLine(c);
                    }
                    else
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    if (e < d)
                    {
                        Console.WriteLine(d);
                    }
                    else
                    {
                        Console.WriteLine(e);
                    }
                }
            }
        }
        else
        {
            if (c < a)
            {
                if (d < a)
                {
                    if (e < a)
                    {
                        Console.WriteLine(a);
                    }
                    else
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    if (e < d)
                    {
                        Console.WriteLine(d);
                    }
                    else
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            else
            {
                if (d < c)
                {
                    if (e < c)
                    {
                        Console.WriteLine(c);
                    }
                    else
                    {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    if (e < d)
                    {
                        Console.WriteLine(d);
                    }
                    else
                    {
                        Console.WriteLine(e);
                    }
                }
            }
        }
    }
}

