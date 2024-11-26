using System;

namespace Coding.Exercise
{
    public class CostCalculator

    {
        public static double CalculateTotalCost(double pricePerUnit, int quantity)
    {
    
            if (quantity > 10)
            {
                pricePerUnit = pricePerUnit * 0,9;
            }



        double totalCost = pricePerUnit * quantity;
        return totalCost;

    }

    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Cena za jednostkę: 20, Ilość: 12, Całkowity koszt: {CalculateTotalCost(20, 12)} zł");


        }
    }
}
