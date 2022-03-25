using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsallariListele
{
    class Program
    {
        static void Main(string[] args)
        {
            int girilen, sayac, kontrol, asal;  
            Console.Write("Sayıyı Giriniz: ");  
            girilen = Convert.ToInt32(Console.ReadLine());  

            for (kontrol = 2; kontrol <= girilen; kontrol++)  
            {
                asal = 1;
                for (sayac = 2; sayac < kontrol; sayac++)  
                {
                    if (kontrol % sayac == 0)  
                    {
                        asal = 0;
                    }
                }
                if (asal == 0)
                {

                }
                else
                {
                    Console.WriteLine(kontrol);  
                }
            }

        }
    }
}
