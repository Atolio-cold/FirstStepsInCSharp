using System;
using Microsoft.VisualBasic;

namespace Coding.Exercise
{
    public class TemperatureAnalyzer
    {
        int[] temperatures = { 10, 15, 12, 6, 7, 8 };
        public static int FindHighestTemperature(int[] temperatures)
        {
            int highest = temperatures[0];

            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[i] > highest)
                {
                    highest = temperatures[i];
                }

            }
            return highest;
        }

        public static int FindLowestTemperature(int[] temperatures)
        {

            int lowest = temperatures[0];

            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[i] < lowest)
                {
                    lowest = temperatures[i];
                }
            }

            return lowest;
        }

    }
}