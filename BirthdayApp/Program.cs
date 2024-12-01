using System;
using System.Text;

namespace BirthdayApp
{

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Wprowadź datę w formacie RRRR-MM-DD");
            string userInput = Console.ReadLine();

            if (DateTime.TryParse(userInput, out DateTime Birth))
            {
                DateTime DateNow = DateTime.Now;

                TimeSpan difference = DateNow - Birth;

                Console.WriteLine($"Od twoich dni mineło: {difference.Days} ");
            }
            else
            {
                Console.WriteLine("Niepoprawny format daty. Spróbuj ponownie.");
            }
        }
    }
}