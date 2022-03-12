using System;

namespace Part2
{
    class Program
    {
        public static int minNum = int.MaxValue;
        static void Main(string[] args)
        {
            int numOfNums = GetValidInputInt("How many number do u want to enter: ");
            int[] ls = GetLsInt(numOfNums);
            Console.WriteLine($"Min num is {GetMinNum()}");
            Console.WriteLine($"Min num is {GetMinNum(ls)}");
        }

        static int[] GetLsInt(int numOfNums)
        {
            int[] ls = new int[numOfNums];
            for (int i = 0; i < numOfNums; i++)
            {
                int temp = GetValidInputInt($"Enter the {i + 1}th number: ");
                ls[i] = temp;
                if (minNum > temp)
                {
                    minNum = temp;
                }
            }

            return ls;
        }

        static int GetValidInputInt(string message)
        {
            int temp;
            do
            {
                Console.Write(message);
            } while (!Int32.TryParse(Console.ReadLine(), out temp));
            return temp;
        }

        static int GetMinNum()
        {
            return minNum;
        }
        
        static int GetMinNum(int[] ls)
        {
            int min = int.MaxValue;
            for (int i = 0; i < ls.Length; i++)
            {
                if (min > ls[i])
                {
                    min = ls[i];
                }
            }
            return min;
        }
    }
}
