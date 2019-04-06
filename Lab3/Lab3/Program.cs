using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Both check to see if something is true and then executes next statement if it is, a single-selection does it once and then stops, while a "while" statement
            // after executing the next statement it will check the if statement again and continue the percedure.
            // Question 3
            int speedLimit = 35;
            int speed = 42;
            if (speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW");
            }
            Console.ReadLine();

            // Question 4
            bool isTrue = true;
            TestAndDisplay(isTrue);

            isTrue = false;
            TestAndDisplay(isTrue);

            // Question 5
            Console.WriteLine("Enter the temperature to convert to Celsius");

            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32d) * 5d / 9d;

            Console.WriteLine(celsius);
            if (fahrenheit < 40)
            {
                Console.WriteLine("It is cold");
            } else if (fahrenheit > 90)
            {
                Console.WriteLine("It it hot");
            }

            Console.ReadLine();

            //Question 6
            int n = 1;
            while (n < 11)
            {
                Console.WriteLine(n);
                n++;
            }
            Console.ReadLine();
            //Question 7
            int b = 60;
            while (b > 19)
            {
                Console.WriteLine(b);
                b = b - 5;
            }
            Console.ReadLine();
            //Question 8
            int c = 10;
            while (c < 21)
            {
                Console.WriteLine(c);
                c = c + 2;
            }
            Console.ReadLine();
        }

        static void TestAndDisplay(bool testValue)
        {
            if (testValue)
            {
                Console.WriteLine("it is True!");
            }
            else
            {
                Console.WriteLine("it is False!");
            }

        }
    }
}
