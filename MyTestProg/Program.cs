using System;
using System.Collections.Generic;

using MyTestLib;

namespace MyTestProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyTestProg");

            var testClass = new MyTestClass();
            var myList = new List<double>()
            {
                1, 1, 2, 3, 5, 8, 13
            };

            var sum = testClass.SumListValues(myList);

            Console.WriteLine("Values: ");

            foreach(var val in myList)
            {
                Console.Write($"{val} ");
            }

            Console.WriteLine($"\nSum: {sum}");
        }
    }
}
