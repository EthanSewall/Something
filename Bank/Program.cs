using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Bank
    {
        private float currentBalance;
        public void Deposit(float net)
        {
            currentBalance += net;
        }
        public float Withdraw()
        {
            float retrievedBalance = currentBalance;
            currentBalance = 0;
            return retrievedBalance;
        }
        public float Balance()
        {
            return currentBalance;
        }
    }
}
