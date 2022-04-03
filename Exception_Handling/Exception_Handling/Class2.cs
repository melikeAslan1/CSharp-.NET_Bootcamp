using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling
{
    class Class2
    {
        static void Main(string[] args)
        {
           

            try
            { 
                Console.WriteLine("Number 1 is: ");
                 int number1 = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Number 2 is: ");
                   int number2 = Convert.ToInt32(Console.ReadLine());

                int division = number1 / number2;
                Console.WriteLine("result= " + division);
            }
            catch (FormatException)
            {

                Console.WriteLine("Please just give digits");
            }

            catch(DivideByZeroException)
            {
                Console.WriteLine("number 2 can not be 0");
            }






        }
    }
}
