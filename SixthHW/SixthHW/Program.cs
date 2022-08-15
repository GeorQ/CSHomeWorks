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
            Repository repos = new Repository();
            while (!isOver)
            {
                option = repos.CorrectParseInt("Enter 1 - to read all files\nEnter 2 - to add new record\nEnter 3 - to add dummy record\nEnter 4 - to delete record\n" +
                    "Enter 5 - to choose record from the date range\nEnter 6 - to clear console\nEnter 7 - to print debug data\nEnter 8 - to terminate program and save records\n" +
                    "Your input: ", 1, 8);
                switch (option)
                {
                    case 1:
                        repos.PrintAllRecords();
                        break;
                    case 2:
                        repos.AddNewRecord();
                        break;
                    case 3:
                        repos.AddDummyRecord();
                        break;
                    case 4:
                        int id = repos.CorrectParseInt($"Enter id of worker to be deleted. It should be between 0 - {repos.CurrentIndex - 1}: ",0, repos.CurrentIndex - 1);
                        repos.DeleteWorker(id);
                        break;
                    case 5:
                        Console.Write("Enter start date in the following format (dd.mm.year): ");
                        string startDate = Console.ReadLine();
                        Console.Write("Enter end date in the following format (dd.mm.year): ");
                        string endDate = Console.ReadLine();
                        repos.PrintWorkerInDateFrame(startDate, endDate);
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    case 7:
                        repos.DebugLog();
                        break;
                    case 8:
                        repos.WriteAllRecords();
                        isOver = true;
                        break;
                }
            }
        }
    }
}