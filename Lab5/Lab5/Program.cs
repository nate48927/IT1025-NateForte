using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //2)
            //a. The scope is public, the other possible value is static, this means that the method can be used in other methods.
            //b. a static method can not be instantiated, while a non-static method can, "public" is what is declaring this method as a non-static method.
            //c. The return type in this case is double, other possible values are int or a string, the significance of this is to assign a data type to the return data.
            //d. The method name is getArea, you can name a method anything you want, but general you name it in a way to signify it's function.
            //e. The parameters are height, and width, other possible parameters are any defined double int or string, these are used to produce the return data.
            //f. The method body is everything inbetween { }, this is the function of the method and will vary method to method.
            //3 A user defined method is hidden from other methods, while methods provided by the frameword can be reused / used in other locations.
            //4) a non-static method can access all non-static fields, while a static method can not access non-static fields.

            Dog myDog = new Dog();
            myDog.Name = "Fido";

            
            myDog.bark();
            myDog.doTrick("Fetch");
            Console.ReadLine();
           
       


        }
    }
    class Dog
    {
        public string Name { get; set; }

       public void bark()
        {
            Console.WriteLine("{0} is Barking...", Name);
        }
        public void doTrick(string trickName)
        {
            Console.WriteLine("{0} is so smart!  {0} is doing a(n) {1}", Name, trickName);
        }


    }
}
