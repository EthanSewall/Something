using System;

namespace ConditionalExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playerAlive = true;

            if(playerAlive)
            {
                Console.WriteLine("the player is alive");
            }
            else
            {
                Console.WriteLine("the player has died");
            }

            int invulnerablityTimer = 4;

            invulnerablityTimer -= 3;

            if(invulnerablityTimer > 0)
            {
                Console.WriteLine("the player is not vulnerable");
                if(playerAlive)
                {
                    invulnerablityTimer--;
                }
            }
            else if (invulnerablityTimer == 0)
            {
                Console.WriteLine("the player is vulnerable");
            }
            else if(invulnerablityTimer < 0)
            {
                invulnerablityTimer = 0;
            }



            Console.ReadKey();
        }
    }
}
