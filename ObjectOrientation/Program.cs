using System;

namespace ObjectOrientation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Arena");
            bool isBattleOver = false;

            Player player = new Player();
            Enemy enemy = new Enemy();
           
            while (!isBattleOver)
            {
                Console.WriteLine("What would you like to do?");
                string playerInput = Console.ReadLine();

                switch(playerInput)
                {
                    case "quit":
                        isBattleOver = true;
                        break;
                    case "check HP":
                        Console.WriteLine(player.healthPoints);
                        break;
                    case "attack":
                        enemy.TakeDamage(player.strength);
                        player.TakeDamage(enemy.strength);
                        break;
                }

                if(enemy.IsDefeated)
                {
                    Console.WriteLine("Victory.");
                    isBattleOver = true;
                }
                else if (player.IsDefeated)
                {
                    Console.WriteLine("Defeat.");
                    isBattleOver = true;
                }
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

            return;
        }
    }
}
