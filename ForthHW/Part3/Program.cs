using System;

namespace Part3
{
    class Program
    {
        static int maxGuess;
        static void Main(string[] args)
        {
            Random rd = new Random();

            do
            {
                maxGuess = GetValidInputInt("Enter max number to guess it should be non negative int which is bigger than 0:  ");
            } while (maxGuess <= 0);

            int guess = rd.Next(maxGuess + 1);
            int currentGuess;
            while (true)
            {
                currentGuess = GetValidInputInt("Enter ur guess: ");
                if (currentGuess == -1)
                {
                    Console.WriteLine("Game Over!");
                    Console.WriteLine($"The right answer was {guess}!");
                    break;
                }
                else if (currentGuess == guess)
                {
                    Console.WriteLine("Congrats u have won!");
                    break;
                }
                else if (currentGuess > guess)
                {
                    Console.WriteLine("Take less!");

                }
                else if (currentGuess < guess)
                {
                    Console.WriteLine("Take more!");
                }
            }
        }

        static int GetValidInputInt(string message)
        {
            int temp;
            string str;

            do
            {
                Console.Write(message);
                str = Console.ReadLine();
                str = str.Trim();
                if (str == "" && maxGuess != -1)
                {
                    return -1;
                }
            } while (!Int32.TryParse(str, out temp) || temp < 0);
            return temp;
        }
    }
}
