using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace FibonacciGenerator
{

    public class FibonacciGenerator
    {
        public IEnumerable<int> GenerateFibonacciNumbers()
        {

            int a = 0;
            int b = 1;
            while (true)
            {
                yield return a;
                int temp = a + b;
                a = b;
                b = temp;
            }
        }
        public class Program
        {
            static void Main(string[] args)
            {
                var generator = new FibonacciGenerator();
                foreach (var number in generator.GenerateFibonacciNumbers())
                {
                    Console.WriteLine(number);
                    if (number > 50) break;
                }

            }


        }
    }
}