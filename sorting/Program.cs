using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] toBeSorted = new int[]
            {
                56,34,23,76,66,62,17,35,23,86,35,91,25,31,75,54,99,11,72,44,85,83,93,68
            };
            Console.WriteLine("Unsorted");
            PrintArray(toBeSorted);
            Console.WriteLine("Sorted");
            BubbleSort(ref toBeSorted);
            PrintArray(toBeSorted);
            Console.ReadLine();
        }
        static void PrintArray(int[] array)
        {
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
        }
        static void BubbleSort(ref int[] array)
        {
            if (array.Length <= 1)
            {
                return;
            }
            bool stillSorting = false;

            do
            {
                stillSorting = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                        stillSorting = true;
                    }
                }

            } while (stillSorting == true);
        }
    }
}
