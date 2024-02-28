using System;

namespace uppgift_6._4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Potenser(2, 4));
        }
        static int Potenser(int bas, int exp)
        {
            int produkt = bas;
            for (int i = 1; i < exp; i++)
            {
                produkt *= bas;
            }
            return produkt;
        }
    }
}
