using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling
{
    public class Class1
    {
         void Main(string[] args)
        {
            try
            {
                byte bigNumber = 254;
                byte smallNumber = 3;

                checked
                {
                    byte total = (byte)(bigNumber + smallNumber);
                    Console.WriteLine("Total");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        


    }
}
