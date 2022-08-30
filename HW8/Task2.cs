using System;
using System.Collections.Generic;
using System.Text;

namespace HW8
{
    class Task2
    {
        public Dictionary<string, string> dict = new Dictionary<string, string>();

        public Task2()
        {
            string fullNameTemp;

            while (true)
            {
                Console.Write("Enter phone number: ");
                string phoneNumber = Console.ReadLine();
                if (phoneNumber.Trim() == "")
                {
                    break;
                }
                Console.Write("Enter full name: ");
                string fullName = Console.ReadLine();
                dict.Add(phoneNumber, fullName);
            }

            while (true)
            {
                Console.Write("Enter phone number to find user: ");
                string phoneNumber = Console.ReadLine();
                if (phoneNumber.Trim() == "")
                {
                    Console.WriteLine("Have a nice day!");
                    break;
                }
                if (dict.TryGetValue(phoneNumber, out fullNameTemp))
                {
                    Console.WriteLine($"This phone number belong to - {fullNameTemp}");
                }
                else
                {
                    Console.WriteLine("There is nobody who has such number");
                }
            }
        }
    }
}
