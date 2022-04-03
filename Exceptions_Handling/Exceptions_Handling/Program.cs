using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            // kodu seç sağ tıkla snippet, surroud with, try.
            try
            {
                double boy, kilo, vücutKitleİndeksi;
                Console.WriteLine("boyunuzu giriniz: ");
                boy = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("boyunuzu giriniz: ");
                boy = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("kilonuzu giriniz: ");
                kilo = Convert.ToDouble(Console.ReadLine());
                vücutKitleİndeksi = kilo / (boy * boy);));

                Console.WriteLine("kilonuzu giriniz: ");
                kilo = Convert.ToDouble(Console.ReadLine());
                vücutKitleİndeksi = kilo / (boy * boy);
                Console.WriteLine("vücutKitleEndeksi: " + vücutKitleİndeksi);
            }
            catch (FormatException)
            {

                Console.WriteLine("lütfen doğru formatta değer giriniz."); ;
            }
        }
    }
}
