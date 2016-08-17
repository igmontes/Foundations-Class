using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWorksheet
{
    class Program
    {
        /*static void Main(string[] args)
        {

            // Question 7
            int _int = 2;
            string _char = "Hello";

            Console.WriteLine("Question 7");
            Console.WriteLine(_int);
            Console.WriteLine(_char);
            Console.WriteLine();
            Console.WriteLine();


            // Question 14
            int x = 10;
            int y = 20;
            int z = 30;
            int t = 40;

            x = x / -1;
            y = y + 2;
            z = z + z;
            t += t;

            Console.WriteLine("Question 14");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(t);


            // Question 21
            int X = 4;
            int result;

            result = X + X++;
            result = --X + X;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Question 21");
            Console.WriteLine(result);



            // Question 24
            int usCnt = 10;
            int usSum = 10;


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Question 24");
            if (usSum++ == usCnt)
            {
                Console.WriteLine("First");
            }

            if (usSum == ++usCnt)
            {
                Console.WriteLine("Second");
            }



            // Question 25
            usSum = 10; usCnt = 2;
            switch (usCnt)
            {
                case 3:
                    {
                        usSum = usSum + 2;
                        break;
                    }
                default:
                    {
                        break;
                    }
                case 2:
                    {
                        usSum = usSum * 3;
                        goto case 3;
                    }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Question 25");
            Console.WriteLine(usSum);

            Console.ReadLine();
        } */




        // Question 27
        /*static void Main()
        {
            uint usCnt;
            uint usSum = 0;

            for (usCnt = 10; usCnt >= 0; usCnt--)
            {
                Console.WriteLine("{0}", usCnt);
                usSum = usSum + usCnt;
            }
            Console.WriteLine(usSum);
            Console.ReadLine();
        }*/


        // Question 28
        static void Main()
        {
            int iX;
            int iY;

            iX = 15321;
            while (iX != 0)
            {
                iY = iX % 10;
                Console.Write(iY);
                iX /= 10;
            }
            Console.WriteLine();
            Console.ReadLine();
        }


    }
}
