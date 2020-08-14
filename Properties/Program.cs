using System;
using System.Runtime.CompilerServices;

namespace Properties
{
    class Program
    {
        float money = 2;
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
        void WriteTheThings()
        {
            Console.WriteLine(USD + " USD = " + canadian + "canadian");
        }


        public float USD
        {
            get
            {
                return money;
            }
        }

        public float canadian
        {
            get 
            {
                return money * (1.33f);
            }
        }
    }
}
