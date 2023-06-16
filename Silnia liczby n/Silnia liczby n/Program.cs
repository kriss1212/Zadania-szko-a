
using System;

class Program
{
    static int Factorial(int number)
    {
        if (number <= 1)
            return 1;
        else
            return number * Factorial(number - 1);
    }

    static void Main(string[] args)
    {
        Console.Write("Wprowadź liczbę x: ");
        int x = int.Parse(Console.ReadLine());

        int n = 0;
        int result = Factorial(n);

        while (result < x)
        {
            n++;
            result = Factorial(n);
        }

        if (result == x)
            Console.WriteLine($"{x} jest silnią liczby {n}.");
        else
            Console.WriteLine($"{x} nie jest silnią żadnej liczby.");

        Console.ReadLine();
    }
}