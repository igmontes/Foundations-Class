using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string input;       // capture input string from screen
            int[] numbers;      // the array
            int element = 0;    // initializing the length of the array
            int count = 1;      // initializing the iterations and the value for the array
            int value;          // holds the number entered on the screen
            double total = 1;   // used for the calculation, initializing to 1

            // Capture the number entered
            Console.WriteLine("Please enter a number:");
            input = Console.ReadLine();

            //initialize the  length of the array and 
            // the value from the screen
            value = int.Parse(input);
            numbers = new int[value];

            // Add a blank line
            Console.WriteLine();

            // Loop to pupulate the array
            do
            {
                // when the iterations reach the number entered
                if (count > value)
                {
                    break;
                }

                // populate the array
                numbers[element] = count;

                // calculate Factorials
                total = total * count;

                // Display output
                Console.WriteLine("{0}! = {1}" ,count ,total);

                // Increment the iteration and array's length count
                element ++;
                count ++;
            } while (count <= value);

            // Hold the screen
            Console.ReadLine();

        }
    }
}
