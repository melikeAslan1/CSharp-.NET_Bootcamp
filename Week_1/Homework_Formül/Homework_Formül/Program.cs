using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10to2
{
    // 10 luk sistemdeki sayıyı 2 lik sisteme çevirme uygulaması.
    class Program
    {
        static void Main(string[] args)
        {
            int Sayi = 75; 

            string ikilikSayim="";

            int kalan = 3;


            while(Sayi!=0)
            {
               kalan = Sayi % 2;

               Sayi= Sayi / 2;

                ikilikSayim = kalan.ToString() + ikilikSayim;

            }
           
            Console.WriteLine("İkilik sistemdeki sayi=" + ikilikSayim);
        }
    }
}
