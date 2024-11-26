using System;

namespace Number
{
    public class IsEvenNumber
    {

        public static bool EvenNumber(int number)
        {

            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public static void Main()
        {

            Console.WriteLine($"Liczba 1 jest parzysta: {EvenNumber(1)}"); // false


            Console.WriteLine($"Liczba 4 jest parzysta: {EvenNumber(4)}"); // true


            Console.WriteLine($"Liczba 6 jest parzysta: {EvenNumber(6)}"); // true
        }


    }
}