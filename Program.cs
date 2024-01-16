using System;
using System.Collections.Generic;

namespace LamdaExample
{
    class QueryOperator
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            double averageNumber = numbers.Where(num => num % 2 == 1).Average();
            Console.WriteLine(averageNumber);
            Console.ReadLine();
        }
    }
}