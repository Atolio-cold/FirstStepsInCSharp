using System;
using System.Text;

namespace CheckEven
{
    class Numbers
    {
        public static void Main()
        {
            Console.WriteLine("Give me a number:");
            string userInput = Console.ReadLine();
            int number;
            if (int.TryParse(userInput, out number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"Number {userInput} is even.");
                }
                else
                {
                    Console.WriteLine($"Number {userInput} isn't even.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }


        }
    }
}