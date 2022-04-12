using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter message: ");
            string str = Console.ReadLine();
            string[] array1 = Split(str);
            string[] array2 = Splitv2(str);

            string[] reversedArray = ReversWords(str);
            PrintArray(reversedArray);
        }

        static string[] Split(string str)
        {
            return str.Split();
        }

        static string[] Splitv2(string str)
        {
            if (str.Length == 0 || (str.Length == 1 && str[0] == ' '))
            {
                return null;
            }

            int numberOfElements = 1;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == ' ' && str[i + 1] != ' ')
                {
                    numberOfElements++;
                }
            }

            string[] result = new string[numberOfElements];
            string temp = "";
            int index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                temp += str[i];
                if (str[i] == ' ')
                {
                    result[index++] = temp;
                    temp = "";
                }
            }

            result[index] = temp;

            return result;

        }
        
        static void PrintArray(string[] array)
        {
            if (array.Length == 0)
            {
                return;
            }

            foreach (string word in array)
            {
                Console.Write($"{word} ");
            }
        }
        static string[] ReversWords(string inputPhrase)
        {
            string[] array = Splitv2(inputPhrase);
            string temp;
            int middle = array.Length / 2;
            for (int i = 0; i < middle; i++)
            {
                temp = array[array.Length - i - 1];
                array[array.Length - i - 1] = array[i];
                array[i] = temp;
            }
            return array;
        }
    }
}
