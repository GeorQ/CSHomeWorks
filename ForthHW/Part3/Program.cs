using System;

namespace Part3
{
    class Program
    {
        //Да это костыль, лень думать, просто не хочу чтоб при пустой строке ретернило -1 это будет ошибкой на 14 линии кода, 
        //при попытке создания рандом числа от -1, а сделанно это для того чтоб на 13 линии кода, чел мог по ошибке ввести пустую строку! 
        static int maxGuess = -1;
        static void Main(string[] args)
        {
            Random rd = new Random();
            maxGuess = GetValidInputInt("Enter max number to guess: ");
            Console.WriteLine(maxGuess);
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
