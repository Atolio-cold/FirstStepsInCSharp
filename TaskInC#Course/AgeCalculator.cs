using System;
using System.Text;

namespace AgeCalculator
{

    class Program
    {
        public static void Main()
        {

            Console.WriteLine("When you born in year: ");
            string userInputAge = Console.ReadLine();
            double Age = double.Parse(userInputAge);


            if (DateTime.Now.Year - Age < 18)
            {
                Console.WriteLine("You have less than 18.");
            }
            else if (DateTime.Now.Year - Age > 65)
            {
                Console.WriteLine("You are over 65");
            }
            else
            {
                Console.WriteLine("You are between 18 and 65");
            }
        }
    }
}