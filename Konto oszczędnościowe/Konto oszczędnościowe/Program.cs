
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj kwotę początkową: ");
        decimal kwotaPoczatkowa = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Podaj oprocentowanie w skali roku: ");
        decimal oprocentowanie = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Podaj liczbę miesięcy oszczędzania: ");
        int liczbaMiesiecy = int.Parse(Console.ReadLine());

        decimal oprocentowanieMiesieczne = oprocentowanie / 12 / 100;
        decimal kwotaZarobiona = kwotaPoczatkowa * (decimal)Math.Pow((double)(1 + oprocentowanieMiesieczne), liczbaMiesiecy);

        decimal podatekBelki = kwotaZarobiona * 0.19m; // Podatek Belki wynosi 19% kwoty zarobionej

        decimal kwotaKoncowa = kwotaZarobiona - podatekBelki;

        Console.WriteLine("Kwota zarobiona na koncie oszczędnościowym (po uwzględnieniu podatku Belki): " + kwotaKoncowa);
    }
}