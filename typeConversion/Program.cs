using System;

namespace typeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 1;
            long e = long.MaxValue;

            Console.WriteLine(e);
            h = (int)e;
            Console.WriteLine(h);


            Console.ReadKey();
        }
    }
}
