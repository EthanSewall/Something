using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_and_such
{
    class Program
    {
        static void Main(string[] args)
        {
            string opening = "Hello there.";
            int score = 0;
            string scoreDisplay = "The score is " + score + ".";

            Console.WriteLine(opening);
            Console.WriteLine(scoreDisplay);

            Console.ReadKey();
        }
    }
}
