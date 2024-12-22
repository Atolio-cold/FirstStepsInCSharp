using System;

namespace personalizeSayHi
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Insert your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Insert your  age: ");
            string age = Console.ReadLine();
            int ageUserInput = int.Parse(age);

            if (ageUserInput < 0)
            {
                Console.WriteLine("incorrect age");
            }

            else if (ageUserInput > 50)
            {
                Console.WriteLine("Wow, you're really old!");
            }
            else
            {
                Console.WriteLine("You are young man");
            }


            Console.WriteLine();
            Console.WriteLine($"Hi, {name}, Yur're {ageUserInput}");


        }
    }
}