using System;

namespace FirstHW
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessage(false);
            Console.WriteLine();
            PrintMessage(true);

            Console.ReadKey();
        }

        static void PrintMessage(bool isNewLine)
        {
            if (!isNewLine)
            {
                Console.WriteLine("Hello world!!!");
                return;
            }
            Console.Write("Hello ");
            Console.Write("World");
            Console.Write("!!!");
        }
    }
}
