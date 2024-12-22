using System;

namespace GuessTheNumber
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Zgadnij liczbę od 1 do 10:");

            Random random = new Random();
            int rangeNumber = random.Next(1, 11);

            while (true)
            {
                Console.Write("Podaj swoją liczbę: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int userInputInt))
                {
                    if (userInputInt == rangeNumber)
                    {
                        Console.WriteLine("Congratulations! Zgadłeś liczbę!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Źle! Spróbuj ponownie.");
                    }
                }
                else
                {
                    Console.WriteLine("To nie jest liczba! Podaj poprawną liczbę.");
                }
            }
        }
    }
}
