using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double boy, kilo, vücutKitleİndeksi;
                Console.WriteLine("boyunuzu giriniz: ");


                boy = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("kilonuzu giriniz: ");
                kilo = Convert.ToDouble(Console.ReadLine());

                vücutKitleİndeksi = kilo / (boy * boy);
                Console.WriteLine("vücutKitleEndeksi: " + vücutKitleİndeksi);
            }
            catch (Exception e)
            {

                Console.WriteLine("lütfen doğru formatta değer giriniz.");
              
            }
        }
    }
}
