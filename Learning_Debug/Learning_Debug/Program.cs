using System;

namespace Learning_Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            
           var fiyat = 100m;

            var kdvOrani = 18m;

            var kdvTutari = fiyat * kdvOrani * 100m;

            var kdvliTutar = fiyat + kdvTutari;

            Console.WriteLine($"kdv li tutar= {kdvliTutar} ");
        }
    }
}
