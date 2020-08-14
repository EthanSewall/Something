using System;
using System.Reflection.Metadata.Ecma335;

namespace counting
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stillGoing = true;
            short number = 0;
               
           while (stillGoing)
            {
                number++;
                Console.WriteLine(number.ToString());  
            }

        }
    }
}
