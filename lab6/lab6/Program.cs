using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {// 2) the access expressions would be p[0]. p[1], p[2], p[3], and p[4]  
            //  3)
            string[] month = new string[12];
            month[0] = "January";
            month[1] = "February";
            month[2] = "March";
            month[3] = "April";
            month[4] = "May";
            month[5] = "June";
            month[6] = "July";
            month[7] = "August";
            month[8] = "September";
            month[9] = "October";
            month[10] = "November";
            month[11] = "December";
            for(int i = 0; i < 12; i++)
            {

                Console.WriteLine(i + " " + month[i]);
                
            }
            Console.ReadLine();

            // 4)

            string[] season = new string[]
            {
                "Spring", "Summer", "Fall", "Winter"
            };
            foreach(string x in season)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();

            //5)
            Random random = new Random();

            int[] randomNumber = new int[1000];

            for (int a = 0; a < 1000; a++)
            {
                randomNumber[a] = random.Next(0,100);
            }

            foreach (int b in randomNumber)
            {
                Console.WriteLine(randomNumber[b]);
            }
            Console.ReadLine();

            //6)
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int c = 0;
            while (c < names.Length)
            {
                Console.WriteLine(names[c]);
                c++;

            }
            Console.ReadLine();

            //7)
            string[] names2 = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int c2 = 0;
            while (c2 < names2.Length)
            {
                Console.WriteLine("{0,2}. {1}", c2, names2[c2]);
                c2++;

            }
            Console.ReadLine();

            //8)
            string[] names3 = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int c3 = 0;
            foreach (string x in names3)
            {
                Console.WriteLine("{0,2}. {1}", c3, x);
                c3++;

            }
            Console.ReadLine();







        }



    }
}
