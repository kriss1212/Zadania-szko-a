
using System;

class Program
{
    static void Main()
    {
        double x = 2.5; // wartość x, dla której obliczamy funkcję e^x
        int n = 10; // liczba pierwszych wyrazów szeregu Taylora do zsumowania

        double result = CalculateExponential(x, n);
        Console.WriteLine($"Wartość funkcji e^{x} wynosi: {result}");
    }

    static double CalculateExponential(double x, int n)
    {
        double sum = 0;
        double term = 1;

        for (int i = 0; i <= n; i++)
        {
            sum += term;
            term *= x / (i + 1);
        }

        return sum;
    }
}