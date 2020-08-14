using System;

namespace Loooping
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int counter = 0;
            while(counter < 10)
            {
                counter++;
                Console.WriteLine("While has run " + counter.ToString() + " times.");
            }

            for (int forCounter = 0; forCounter <= 20; forCounter++)
            {
                Console.WriteLine("For has run " + forCounter.ToString() + " times.");
            }

            while(score >= 0)
            {
                score += 20;
                if(score > 100)
                {
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
