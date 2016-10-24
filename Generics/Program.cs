using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEssentialTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array is fixed size
            string[] meetings = { "Lake County Sunday", "Little Mountain Monday", "Lake County Tuesday", "Little Mountain Wednesday" };

            foreach (string item in meetings)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();


            string[] family = new string[5];
            family[0] = "Brad";
            family[1] = "Ryan";
            family[2] = "Max";
            family[3] = "Bob";
            family[4] = "Cathy";

            foreach (var item in family)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            int[] weights = { 12, 34, 23, 12, 85 };

            int sumOfWeights = weights.Sum();
            int countOfWeights = weights.Count();

            Console.WriteLine("The sum is " + sumOfWeights);
            Console.WriteLine("There are " + countOfWeights + " elements in this Array.");

            double avgOfWeights = weights.Average();
            Console.WriteLine(avgOfWeights);

            useArray(family);





        }

        static void useArray(string[] values)
        {
            Console.WriteLine("Values in method: ");
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
