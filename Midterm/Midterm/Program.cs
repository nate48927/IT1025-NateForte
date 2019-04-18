using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            //2)
            //three types of loops are while, do while, and for, these loop functions  will repeat a section of code until the condition is no longer met.
            // A while and do while both execute a section of code as long as the condition is true, a do while will always execute once, while potentially 0 times.
            //a for loop does the same thing but the dependant variables are directly nested in the header, this is not the case for while loop.

            //3
            int x = 5;
            Boolean keepLooping = true;
            while (keepLooping)
            {
                if (x <= 4) keepLooping = false;
                x++;
                Console.WriteLine(x);
                //Console.ReadLine();
            }
            //4
            int a = 2;
            while (a <= 65)
            {
                Console.WriteLine("[" + a + "]");
                a = a * 2;

            }
            Console.WriteLine("[" + a + "]");
            Console.ReadLine();

            //5
            for (int q = 49; q > 0; q--)
            {

                Console.Write(q);
                if (q != 1)
                {
                    Console.Write(",");
                }
            }
            Console.ReadLine();

            //6
            int b = 1;
            while (b <= 20)
            {
                Console.Write(b + " ");
                b = b + 2;

            }
            Console.Write(b);
            Console.ReadLine();

            //7
            //the output of the code is "*".
            // if it was a while code it would never execute as I is never < n, as opposed to executing once.

            //8
            bool icyRain = false;
            bool tornadoWarning = false;
            if (!icyRain & !tornadoWarning)
            {
                Console.WriteLine("Let's go outside!");
                Console.ReadLine();
            }
            //9
            
            for (int c = 5; c > 0; c--) {
                for (int f = 5 - c; f > 0; f--)
                {
                    Console.Write(" ");
                }
                for (int d = 1; d < c; d++)
                {
                    Console.Write(d);
                }
                for (int e = c; e > 0; e--)
                {
                    Console.Write(e);
                }
                Console.WriteLine();
            }

            Console.ReadLine();

           

        }

    }
}
