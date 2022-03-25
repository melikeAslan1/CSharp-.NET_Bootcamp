using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Asal
{
    class Program
    {
        static void Main(string[] args)
        {
            int kontrol = 0;
            Console.Write("Sayı Girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi == 1 || sayi == 0)
            {
                Console.WriteLine("Girdiğiniz sayı asal değildir.");

            }
            else
            {
                for (int i = 2; i < sayi / 2; i++)
                {
                    if (sayi % i == 0) 
                    {
                        kontrol++;
                        break; 
                    }

                }

                if (kontrol != 0)
                {
                    Console.WriteLine("Girdiğiniz sayı asal değildir.");
                }

                else
                {
                    Console.WriteLine("Girdiğiniz sayı asaldır.");
                }

            }





        }
    }
}
