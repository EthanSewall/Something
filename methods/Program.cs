using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
           Game currentGame = new Game();
           currentGame.score = 100;
            currentGame.Start();

        }
    }

    class Game
    {
        public int score = 0;

        public void Start()
        {
            Console.WriteLine(score);
            PrintScore(12);
            PrintScore(18);
            PrintScore(20);

            Console.ReadKey();
        }

        public void PrintScore(int add)
        {
            Console.WriteLine("Score increase: " + AddToScore(add));
        }

        public int AddToScore(int add)
        {
            score += add;
            return score;
        }

    }
}
