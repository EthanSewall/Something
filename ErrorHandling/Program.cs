using System;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 1;
            try
            {
                int e = h / 0;
            }
            catch (System.DivideByZeroException except)
            {
                Console.WriteLine(except);
            }
            finally
            {
               
            }


            Console.ReadKey();
        }
    }
}
