using System;
using System.Text;

namespace TemperratureCalculator
{

    class Temperature
    {

        public static void Main()
        {

            Console.WriteLine("Please enter the temperature in Celsius (°C): ");
            string userInput = Console.ReadLine();
            double Celsius = double.Parse(userInput);

            double Fahrenheit = (Celsius * 9 / 5) + 32;

            Console.WriteLine($"The temperature in Farhenheit is: {Fahrenheit}");
        }
    }
}