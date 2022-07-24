using System;
using System.IO;

namespace SixthHW
{
    class Program
    {
        private static int option;
        private static bool isOver = false;
        static void Main(string[] args)
        {
            WorkersHandler wh = new WorkersHandler();
            while (!isOver)
            {
                option = wh.CorrectParseInt("Enter 1 - to read all files\nEnter 2 - to add new record\nEnter 3 - to terminate program\nYour input: ", 1, 3);
                switch (option)
                {
                    case 1:
                        wh.PrintAllRecords();
                        break;
                    case 2:
                        wh.AddNewRecord();
                        break;
                    case 3:
                        wh.WriteAllRecords();
                        isOver = true;
                        break;
                }
            }
        }
    }
}