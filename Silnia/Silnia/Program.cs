using System;

class Program
{
    static void Main(string[] args)
    {
        int n, k;

        // Wczytaj n, upewnij się, że jest większe lub równe 5
        do
        {
            Console.Write("Podaj liczbę n (n >= 5): ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 5);

        // Wczytaj k, upewnij się, że jest większe lub równe 5
        do
        {
            Console.Write("Podaj liczbę k (k >= 5): ");
        } while (!int.TryParse(Console.ReadLine(), out k) || k < 5);

        // Oblicz n!
        int nFactorial = CalculateFactorial(n);

        // Oblicz k!
        int kFactorial = CalculateFactorial(k);

        // Oblicz m
        int m = (nFactorial - kFactorial) / kFactorial;

        Console.WriteLine("Wartość m wynosi: " + m);
    }

    // Metoda do obliczania silni liczby
    static int CalculateFactorial(int number)
    {
        int factorial = 1;

        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}