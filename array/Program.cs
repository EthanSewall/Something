using System;

namespace array
{
    class Program
    {
        static Team theTeam = new Team();
        static void Main(string[] args)
        {
            theTeam.PrintAverage();
        }
    }

    class Employee
    {
        public string name1;
        public string name2;
        public int experience;
    }

    class Team
    {
        Employee[] group = new Employee[4];
        Employee leader = new Employee();

        public void PrintAverage()
        {
            float average = 0;
            int divisor = 0;
            foreach(Employee e in group)
            {
                average += e.experience;
                divisor++;
            }
            average += leader.experience;
            divisor++;
            average /= divisor;

            Console.WriteLine("The average experience is " +average.ToString() + "years.");
        }
    }
}
