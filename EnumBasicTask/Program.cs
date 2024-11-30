using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace FirstProject
{

    public class Program
    {

        public static void Main()
        {
            Console.WriteLine("How old are u?\n1 = if u are older than 18, 2 = if u are younger than 18  ");
            string userInput = Console.ReadLine();

            Age userAge = (Age)Enum.Parse(typeof(Age), userInput);

            if (userAge == Age.Least18)
            {
                Console.WriteLine("You are too young ");
            }
            else
            {
                Console.WriteLine("Hi");
            }


        }

    }
}

