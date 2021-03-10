using System;

namespace SweetNSalty
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare parameter variables; makes it easy to change parameters later
            var startCount = 1;
            var endCount = 1000;
            var firstCheck = 3;
            var secondCheck = 5;
            var numberPerLine = 10;

            // declare constants for strings because you want them to be immutable
            const string sweet = "sweet";
            const string salty = "salty";
            const string sweetNSalty = "sweet'nSalty";

            // declare counter variables
            var sweetCount = 0;
            var saltCount = 0;
            var sweetSaltCount = 0;
            var counter = 1;

            // iterate over all numbers from start to end
            for (int i = startCount; i <= endCount; i += 1)
            {
                // check if divisible by both first and second divisor
                if (i % firstCheck == 0 && i % secondCheck == 0)
                {
                    Console.Write(sweetNSalty + " ");
                    sweetSaltCount += 1;
                }
                // if not both, check if divisible by first divisor only
                else if (i % firstCheck == 0)
                {
                    Console.Write(sweet + " ");
                    sweetCount += 1;
                }
                // if not, check if divisible by second divisor only
                else if (i % secondCheck == 0)
                {
                    Console.Write(salty + " ");
                    saltCount += 1;
                }
                // otherwise, print the number
                else 
                {
                    Console.Write(i + " ");
                }



                if (counter % numberPerLine == 0)
                {
                    Console.WriteLine();
                }

                counter += 1;
            }

            // once you've finished iteration, print the number of each string
            Console.WriteLine();
            Console.WriteLine("Number of sweet: " + sweetCount);
            Console.WriteLine("Number of salty: " + saltCount);
            Console.WriteLine("Number of sweet'nSalty: " + sweetSaltCount);
        }
    }
}
