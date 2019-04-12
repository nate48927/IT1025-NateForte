using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {// 2) The four basic elements of a Counter-controlled repetition are a control variable, an initial value, an increment, and a loop-continuation condition
         // 3) A while and for statement are similar as they are both used to execute counter-controlled repetition. They differ in that a while statement's initial value 
         // and control variable is defined in a separate statement before the while statement. A For statement contains those things in its header (the statement itself).
         // 4) A do-while statement will always execute the sequence once, this can be useful for validation of an external variable. If you were to ask a user to input 
         // an integer that would then be used in your while statement, it will check whether that integer is valid for the statement.  

         // Question 5
            for (int a = 1; a <= 100; a++)
            {
                if ((a % 2) == 0)
                {
                    Console.WriteLine(a + " it's even");
                }
                else
                {
                    Console.WriteLine(a + " it's odd");
                }
            }
            Console.ReadLine();

            //Question 6
            Console.WriteLine("Please enter a temperature");
            int xTemp = Convert.ToInt16(Console.ReadLine());
            if (xTemp < 10)
            {
                Console.WriteLine("Polar Bear");
            }
            else if (xTemp < 20)
            {
                Console.WriteLine("Penguin");
            }
            else if (xTemp < 40)
            {
                Console.WriteLine("Moose");
            }
            else if (xTemp < 50)
            {
                Console.WriteLine("Reindeer");
            }
            else if (xTemp < 60)
            {
                Console.WriteLine("Deer");
            }
            else if (xTemp < 70)
            {
                Console.WriteLine("Turtle");
            }
            else if (xTemp < 80)
            {
                Console.WriteLine("Lion");
            }
            else if (xTemp < 90)
            {
                Console.WriteLine("Fish");
            }
            else
            {
                Console.WriteLine("Bug");
            }
            Console.ReadLine();

            //Question 7
            int i = 10;
            while (i < 21)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
            Console.ReadLine();

            //Question 8
            for (int i2 = 0; i2 < 101; i2++)
            {
                Console.WriteLine(i2);
                Console.WriteLine("********");
            }
            Console.ReadLine();
                



     
        }
    }
}
