using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SixthHW
{
    class WorkersHandler
    {
        private int currentIndex;
        private int maxNumberOfRecords;
        
        //На некст домашке понадобится не ругайтесь
        private int minNumOfOptions = 0;
        private int maxNumOfOptions = 2;
        //

        private string[] records;
        public string path = @"workers.txt";
        
        public WorkersHandler()
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            UpdateAllRecords();
        }

        public void UpdateAllRecords()
        {
            string[] records = File.ReadAllLines(path);
            currentIndex = records.Length;
            maxNumberOfRecords = records.Length * 2 + 3;
            this.records = records;
            Resize();
        }

        public void WriteAllRecords()
        {
            string result = "";
            foreach (string record in records)
            {
                if (record != null)
                {
                    result += record + "\n";
                }
            }
            File.WriteAllText(path, result);
        }

        public void AddNewRecord()
        {
            string fullName = CorrectParseString("Enter your full name: ");
            Console.WriteLine();
            int age = CorrectParseInt("Enter your age, it should be number between 12 and 150\nInput: ", 12, 150);
            Console.WriteLine();
            int height = CorrectParseInt("Enter your height, it should be number between 40 and 240\nInput: ", 40, 240);
            Console.WriteLine();
            string dateOfBirth = CorrectParseString("Enter your date of birth in following format 01.01.2000\nInput: ");
            Console.WriteLine();
            string placeOfBirth = CorrectParseString("Enter your place of birth\nInput: ");
            string finalString = $"{currentIndex}#{DateTime.Now.ToString("dd.MM.yyyy HH:mm")}#{fullName}#{age}#{height}#{dateOfBirth}#город {placeOfBirth}";
            records[currentIndex++] = finalString;
            if (maxNumberOfRecords - 3 < currentIndex)
            {
                maxNumberOfRecords *= 2;
                Resize();
            }
        }

        public int CorrectParseInt(string message, int minNum, int maxNum)
        {
            int result;
            do
            {
                Console.Write(message);
            } while (!(Int32.TryParse(Console.ReadLine(), out result) && result >= minNum && result <= maxNum));
            return result;
        }

        public string CorrectParseString(string message)
        {
            string str;
            do
            {
                Console.Write(message);
                str = Console.ReadLine().Trim();
            } while (str == "");
            return str;
        }


        public void PrintAllRecords()
        {
            Console.WriteLine("\n\n" + String.Concat(Enumerable.Repeat("*", 100)));
            Console.Write("Records:");
            foreach (string record in records)
            {
                if (record != null)
                {
                    Console.WriteLine(record);
                }
            }
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 100)) + "\n\n");
        }

        public void Resize()
        {
            string[] temp = new string[maxNumberOfRecords];
            for (int i = 0; i < currentIndex; i++)
            {
                temp[i] = records[i];
            }
            records = temp;
        }
    }
}
