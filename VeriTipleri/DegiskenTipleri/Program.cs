using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //sayisal veri tipleri:
            byte age = 255; //byte 8 bit 2 üzeri 8=256. 0 değerini çıkarıyorum en çok 255 değerini alır. byte - olamaz. 
            sbyte negativedeger = -4;  // negatif değer alabilir. işaret alabilen byte tır. 8 bit in 1 i işaret içindir. 2 üzeri 7=128.   -128 ie 127 arasındaki değerleri alır. 

            // byte tan sonraki diğer değerler - alabiliyor.

            short length = 32767;  //16 bit. 2 üzeri 16=65.536     -32.768 ile 32.767 arasındaki değerlei alır. 
            ushort unsighnedShort = 65535;   // unsighned short. işaretsiz short tur.  0 ile 65535 arasındaki değerleri alır. 

            int totalYear = 100000000;  //32 bittir. 2 üzeri 32=
            uint unsighnedint = 35;                // işaretsiz int. yani - değer almayan. 

            long watchCount = 1000000000000; // 64 bittir.
            ulong unsighnedLong = 450000000;

            double pi = 3.14;  //tam sayıyı bi yerde virgülü sayıyı bir yerde tutuyor. ondalıklıda en çok bu tutulur.

            float discount = 0.15f;   // f yi koymak zorundayım. 

            decimal formulaConstant = 0.0000000000000001M;   // en hassas ve ondalıklı en çok yer kaplayan veri tipi. 


            //sözel:

            //matematik işlem yapmayacağın zaman sayısal değer kullanılmaz. mesela tel no sözel dir.

            char character = '!';    //klavyedei her hangi bir tuş karakterdir. 
            string word = "Türkay Ürkmez";


            //mantksal:




        }
    }
}
