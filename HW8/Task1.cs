using System;
using System.Collections.Generic;
using System.Text;

namespace HW8
{
    class Task1
    {
        public List<int> numbers = new List<int>();

        public Task1()
        {
            FillList(100);
            PrintList();
            Console.WriteLine("\n\n\n");
            RemoveElements(25, 50);
            PrintList();
        }

        public void FillList(int numberOfElemnts)
        {
            Random rand = new Random();
            for (int i = 0; i < numberOfElemnts; i++)
            {
                numbers.Add(rand.Next(101));
            }
        }

        public void RemoveElements(int min, int max)
        {
            int[] temp = new int[numbers.Count];
            int pointer = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (!(numbers[i] >= min && numbers[i] <= max))
                {
                    temp[pointer++] = numbers[i];
                }
            }
            numbers.Clear();
            foreach (int item in temp)
            {
                if (item != 0)
                {
                    numbers.Add(item);
                }
            }
        }

        public void PrintList()
        {
            foreach (int item in numbers)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
