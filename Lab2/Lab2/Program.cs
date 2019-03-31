using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        { // 5a This is where the application begins executing
            // 5b A double variable can represent a decimal, while an integer only represents a whole number, an integer takes up less space than a double.
            // 5c An example of a method in chapter 4 is GetName
            // 5d To read the value of a variable we create a get accessor to assign a value to a variable we create a set accessor.
            // 5e A class is a collection of objects, where an object is a particular representation of the class its in.
            int number1;
            int number2;
            int product;
            Console.WriteLine("Enter first integer");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integer");
            number2 = Convert.ToInt32(Console.ReadLine());
            product = number1 * number2;
            Console.WriteLine("Product is {0}", product);
            Console.WriteLine("Hello World!" + System.Environment.NewLine + "From Nate");
            Console.WriteLine("Hello World!" + "\t" + "From Nate");
            Console.ReadLine();
        }
    }
}
