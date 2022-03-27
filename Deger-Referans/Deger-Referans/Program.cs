using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deger_Referans
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler1 = { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = { "Adana", "Bursa", "Bolu" };
            sehirler2 = sehirler1;

            Console.WriteLine(sehirler1[0]);
            Console.WriteLine(sehirler2[1]);



        }
    }
}
