using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCards;
            int sum = 0;
            do
            {
                Console.Write("Enter the total ammount of cards you have: ");
            } while (!Int32.TryParse(Console.ReadLine(), out numOfCards));
            
            for (int i = 0; i < numOfCards; i++)
            {
                Console.Write("Enter card: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        sum += 1;
                        break;
                    case "2":
                        sum += 2;
                        break;
                    case "3":
                        sum += 3;
                        break;
                    case "4":
                        sum += 4;
                        break;
                    case "5":
                        sum += 5;
                        break;
                    case "6":
                        sum += 6;
                        break;
                    case "7":
                        sum += 7;
                        break;
                    case "8":
                        sum += 8;
                        break;
                    case "9":
                        sum += 9;
                        break;
                    case "10":
                        sum += 10;
                        break;
                    case "J":
                        sum += 10;
                        break;
                    case "Q":
                        sum += 10;
                        break;
                    case "K":
                        sum += 10;
                        break;
                    case "T":
                        sum += 10;
                        break;
                    default:
                        sum += 0;
                        break;
                }
            }
            Console.WriteLine($"You sum is {sum}");
            Console.ReadKey();
        }
    }
}
