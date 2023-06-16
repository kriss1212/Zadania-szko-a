
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę wyrazów do wygenerowania: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ciąg Fibonacciego:");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}