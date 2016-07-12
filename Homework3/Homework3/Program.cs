using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables, defaulting all but the seconds
            // seconds will come from the user input
            string seconds;
            string convert;
            decimal finalvalue;
            int minute = 60;
            int hour = 3600;
            int day = 86400;

            do
            {
            StartProgram:
                // ask user for a number of seconds
                Console.WriteLine("Enter how many seconds you want, or enter 'end' to quit ");
                seconds = Console.ReadLine();
                if (seconds == "end")
                {
                    Console.WriteLine("Thanks for playing along.");
                    Console.ReadLine();
                    return;

                }

                // ask user what to convert the seconds to
                Console.WriteLine("Convert to minutes, hours, or days? ");
                convert = Console.ReadLine();

                // verify we are converting to a valid selection
                switch (convert)
                {
                    case "minutes":
                        finalvalue = Convert.ToDecimal(seconds) / minute;
                        break;

                    case "hours":
                        finalvalue = Convert.ToDecimal(seconds) / hour;
                        break;

                    case "days":
                        finalvalue = Convert.ToDecimal(seconds) / day;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid value to convert to");
                        Console.WriteLine("Press enter and start again.");
                        convert = Console.ReadLine();
                        goto StartProgram;
                        break;
                }

                // display the output
                Console.WriteLine("You have chosen to convert to {0}", convert);
                Console.WriteLine("Your final value is {0} {1}", finalvalue, convert);
                Console.ReadLine();

            } while (seconds != "end");

        }
    }
}
