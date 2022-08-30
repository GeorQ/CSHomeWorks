using System;
using System.Collections.Generic;
using System.Text;

namespace HW8
{
    class Task3
    {
        HashSet<int> set = new HashSet<int>();

        public Task3()
        {
            while (true){
                int temp;
                Console.Write("Enter number (empty string to terminate): ");
                string input = Console.ReadLine();
                if (input.Trim() == "")
                {
                    Console.WriteLine("Have a nice day!");
                    break;
                }
                else if (!Int32.TryParse(input, out temp))
                {
                    Console.WriteLine("Impossible to parse!");
                }
                else if (!set.Add(temp))
                {
                    Console.WriteLine("There is such number in set!");
                }
                else
                {
                    Console.WriteLine("Number was added to the set!");
                }
            }
        }
    }
}
