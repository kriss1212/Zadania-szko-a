using System;

public class NumberGuessingAlgorithm
{
    public static void Main()
    {
        int min = 1;
        int max = 20;
        int guess;
        int response;

        Console.WriteLine("Pomyśl o liczbie z przedziału 1-20.");
        Console.WriteLine("Naciśnij dowolny klawisz, aby rozpocząć zgadywanie.");
        Console.ReadKey();

        do
        {
            // Wybieramy środkową liczbę z przedziału
            guess = (min + max) / 2;

            Console.WriteLine("Czy myślona liczba to {0}? (Wpisz: -1, 0, 1)", guess);
            response = Convert.ToInt32(Console.ReadLine());

            if (response == -1)
            {
                // Szukana liczba jest mniejsza od zgadywanej
                max = guess - 1;
            }
            else if (response == 1)
            {
                // Szukana liczba jest większa od zgadywanej
                min = guess + 1;
            }

        } while (response != 0);

        Console.WriteLine("Odgadłem! Myślona liczba to {0}.", guess);
    }
}
