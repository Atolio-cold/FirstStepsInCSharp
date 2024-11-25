using System;
using System.Text;

namespace CommonOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            int x = 6;
            int y = 13;

            result = (x + y);
            Console.WriteLine("Addition Operator: x + y = " + result);

            result = (x - y);
            Console.WriteLine("Subtraction Operator: x - y = " + result);

            result = (x * y);
            Console.WriteLine("Multiplication Operator: x * y = " + result);

            result = (x / y);
            Console.WriteLine("Division Operator: x / y = " + result);

            result = (x % y);
            Console.WriteLine("Modulo Operator: x % y = " + result);

            int value = (2 + 2) * 5; //20

            Console.WriteLine("*******************");

            int value1 = 15;
            int value2 = 20;

            Console.WriteLine("Pre-increment result:");
            Console.WriteLine(++value1);


            Console.WriteLine("Post-increment result:");
            Console.WriteLine(value2++);
            Console.WriteLine(value2);

            Console.WriteLine("***************");
            bool boolResult;
            x = 12;
            y = 18;

            boolResult = (x == y);
            Console.WriteLine("Equal to Operator: (x == y) = " + boolResult);

            boolResult = (x > y);
            Console.WriteLine("Greater than Operator: (x > y) = " + boolResult);

            boolResult = (x < y);
            Console.WriteLine("Less than Operator: (x < y) = " + boolResult);

            boolResult = (x >= y);
            Console.WriteLine("Greater than or Equal to: (x >= y) =  " + boolResult);

            boolResult = (x <= y);
            Console.WriteLine("Lesser than or Equal to: (x <= y) = " + boolResult);

            boolResult = (x != y);
            Console.WriteLine("Not Equal to Operator: (x != y) = " + boolResult);

            Console.WriteLine("***************");

            bool a = true;
            bool b = false;

            boolResult = a && b;
            Console.WriteLine("AND Operator: a && b = " + boolResult);

            boolResult = a || b;
            Console.WriteLine("OR Operator: a || b = " + boolResult);

            boolResult = !a;
            Console.WriteLine("NOT Operator: !a = " + boolResult);

            Console.WriteLine("***************");
            x = 15;
            y = 32;

            int greaterNumber = x > y ? x : y;
            Console.WriteLine("Ternary conditional operator: x > y ? x : y = " + greaterNumber);


        }
    }
}