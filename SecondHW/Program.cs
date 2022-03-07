using System;

namespace SecondHW
{
    class Program
    {
        static void Main(string[] args)
        {
            //FistTask();
            SecondTask();
            Console.ReadKey();
        }

        private static void FistTask()
        {
            string fullName = "Giorgii Kartlelishvili";
            byte age = 21;
            string email = "gerorqv2@icloud.com";
            int itScore = 1;
            int mathScore = 94;
            int physicsScore = 84;

            Console.WriteLine($"My name is {fullName}, I am {age} years old.\n" +
                $"You can contact me via {email}, I faild my IT exam and got {itScore}, " +
                $"but for the math and physics I got {mathScore} and {physicsScore} respectively.");
        }

        private static void SecondTask()
        {
            int sum = 0;
            float avarage = 0;
            int temp;
            Random rd = new Random();
            int[] scores = new int[10];
            for (int i = 0; i < scores.Length; i++)
            {
                temp = rd.Next(30, 100);
                scores[i] = temp;
                sum += temp;
            }
            avarage = (float) sum / (float) scores.Length;

            Console.WriteLine($"Sum is {sum}\nAvarage is {avarage}");
        }

    }
}
