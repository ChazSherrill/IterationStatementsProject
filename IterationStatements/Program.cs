using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0

            var newNumber = 0;

            // Create a do-while loop
            do
            {
                newNumber++;
                numbers.Add(newNumber);
            }
            while (newNumber < 100);



            // Create a while loop
            // While your variable is less than 200
            while (newNumber < 200)
            {
                // Increment your variable by 1
                // Then add your variable to "numbers"
                newNumber++;
                numbers.Add(newNumber);
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            foreach(int x in numbers)
            {
                Console.WriteLine(x);
            }
            // Write your variable to the console

            Console.WriteLine("");
            Console.WriteLine("Decrease:");
            int t = 0;
            // Create a for loop
            for ( t = 199; t <= numbers.Count && t >= 0; t--)
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            {
                // Write to the console "numbers" at index i
                Console.WriteLine(numbers [ t ]);
            }
        }
    }
}
