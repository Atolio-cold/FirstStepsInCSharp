using System;

namespace BirthdayApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Wprowadź datę w formacie RRRR-MM-DD");
            string userInput = Console.ReadLine();

            // Sprawdzenie poprawności wprowadzonej daty
            if (DateTime.TryParse(userInput, out DateTime YearOfBrith))
            {
                YearOfBrith = new DateTime(DateTime.Today.Year, YearOfBrith.Month, YearOfBrith.Day);
            }
            else
            {
                Console.WriteLine("Niepoprawny format daty.");
                return;
            }

            // Sprawdzenie, czy dzisiaj są urodziny
            if (YearOfBrith.Date == DateTime.Today.Date)
            {
                Console.WriteLine("Dzisiaj są Twoje urodziny!");
                return; // Zakończ program, jeśli dzisiaj są urodziny
            }

            // Jeśli urodziny już były, dodaj 1 rok
            if (YearOfBrith < DateTime.Today)
            {
                YearOfBrith = YearOfBrith.AddYears(1);
            }

            // Obliczenie różnicy w dniach
            TimeSpan difference = YearOfBrith - DateTime.Today;
            Console.WriteLine($"Do Twoich urodzin zostało: {difference.Days} dni.");
        }
    }
}

