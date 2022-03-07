using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.Write("Enter integer: ");
            } while (!Int32.TryParse(Console.ReadLine(), out num));
            if (IsEven(num))
            {
                Console.WriteLine($"{num} is even number");
            }
            else
            {
                Console.WriteLine($"{num} is odd number");
            }
            Console.ReadKey();
        }

        static bool IsEven(int num)
        {
            if(num % 2 == 0)
            {
                return true;
            } 
            return false;
        }
    }
}
