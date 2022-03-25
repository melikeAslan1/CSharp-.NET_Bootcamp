using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_VücutKitleEndeksiHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            double boy, kilo, vücutKitleİndeksi;
            Console.WriteLine("boyunuzu giriniz: ");
            boy = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("kilonuzu giriniz: ");
            kilo = Convert.ToDouble(Console.ReadLine());
            vücutKitleİndeksi = kilo / (boy * boy);

            if (vücutKitleİndeksi < 18)
            {
                Console.WriteLine("zayıfsınız.");
            }
            else if (vücutKitleİndeksi >= 18 && vücutKitleİndeksi < 25)
            {
                Console.WriteLine("Kilonuz normal.");
            }
            else if (vücutKitleİndeksi >= 25 && vücutKitleİndeksi < 30)
            {
                Console.WriteLine("kilolusunuz");
            }
            else if (vücutKitleİndeksi >= 30 && vücutKitleİndeksi < 35)
            {
                Console.WriteLine("obezsiniz.");
            }
            else
            {
                Console.WriteLine("ciddi derecede obezsiniz.");
            }


        }
    }
}
