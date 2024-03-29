﻿using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.Write("Enter number to check: ");
            } while (!Int32.TryParse(Console.ReadLine(),out num));
            if (IsPrimeWhile(num))
            {
                Console.WriteLine($"Number {num} is prime");
            }
            else
            {
                Console.WriteLine($"Number {num} is not prime");
            }
            Console.ReadKey();
        }
        
        static bool IsPrime(int num)
        {
            for (int i = 2; i < (int) MathF.Sqrt(num) + 1; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsPrimeWhile(int num)
        {
            int factor = (int) MathF.Sqrt(num) + 1;
            while (factor > 1 && factor != num)
            {
                if (num % factor-- == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
