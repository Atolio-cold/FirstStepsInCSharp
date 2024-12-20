using System;
using System.Reflection;

namespace Coding.Exercise
{
    public class TemperatureConverter
    {
        public void ConvertCelsiusToFahrenheit(double celsius, out double fahrenheit)
        {
            // todo
            fahrenheit = (celsius * 9 / 5) + 32;
        }

        public void ConvertFahrenheitToCelsius(double fahrenheit, ref double celsius)
        {
            // todo
            celsius = (fahrenheit - 32) * 5 / 9;
        }
    }

    class Program
    {
        public static void Main()
        {
            var converter = new TemperatureConverter();

            double fahrenheitResult;
            converter.ConvertCelsiusToFahrenheit(25, out fahrenheitResult);
            Console.WriteLine($"25°C to {fahrenheitResult}°F");

            double celsiusResult = 0;
            converter.ConvertFahrenheitToCelsius(77, ref celsiusResult);
            Console.WriteLine($"77°F to {celsiusResult}°C");
        }
    }

}
