using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SixthHW
{
    class Repository
    {
        public int CurrentIndex { get; private set; }
        private int maxNumberOfRecords;
        
        //На некст домашке понадобится не ругайтесь
        private int minNumOfOptions = 0;
        private int maxNumOfOptions = 2;
        //

        private Worker[] records;
        public string path = @"workers.txt";
        
        public Repository()
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            UpdateAllRecords();
        }

        private Worker[] GetAllWorkers()
        {
            return new Worker[4];
        }

        private Worker GetWorkerById(int id)
        {
            return new Worker();
        }

        public void DeleteWorker(int id)
        {
            if(id >= CurrentIndex || id < 0)
            {
                Console.WriteLine("There is no such ID!");
                return;
            }
            CurrentIndex--;
            while (id != CurrentIndex)
            {
                records[id] = records[id + 1];
                records[id].Id--;
                id++;
            }
            records[id].Ready = false;
        }

        private void UpdateAllRecords()
        {
            string[] records = File.ReadAllLines(path);
            CurrentIndex = 0;
            maxNumberOfRecords = records.Length * 2 + 8;

            this.records = new Worker[maxNumberOfRecords];
            foreach (string record in records)
            {
                if (record.Trim() != "")
                {
                    Worker temp = new Worker(record);
                    this.records[CurrentIndex++] = temp;
                }
            }
        }

        public void WriteAllRecords()
        {
            string result = "";
            foreach (Worker worker in records)
            {
                if (worker.Ready)
                {
                    result += worker.WorkerToString() + "\n";
                }
            }
            File.WriteAllText(path, result);
        }

        //For test purposes 
        public void AddDummyRecord()
        {
            Worker temp = new Worker(CurrentIndex, "Ivan", 24, 190, "20.08.2015", "Moscow");
            records[CurrentIndex++] = temp;
            if (maxNumberOfRecords - 3 < CurrentIndex)
            {
                maxNumberOfRecords *= 2;
                Resize();
            }
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
            Worker temp = new Worker(CurrentIndex, fullName, age, height, dateOfBirth, placeOfBirth);
            records[CurrentIndex++] = temp;
            if (maxNumberOfRecords - 3 < CurrentIndex)
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
            foreach (Worker worker in records)
            {
                if (worker.Ready)
                {
                    Console.WriteLine(worker.WorkerToString());
                }
            }
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 100)) + "\n\n");
        }

        public void Resize()
        {
            Worker[] temp = new Worker[maxNumberOfRecords];
            for (int i = 0; i < CurrentIndex; i++)
            {
                temp[i] = records[i];
            }
            records = temp;
        }

        //This function will be used for debug only
        public void DebugLog()
        {
            Console.WriteLine($"\n\nCurrent index - {CurrentIndex}\nArray size - {records.Length}\nMax array size - {maxNumberOfRecords}\n\n");
        }

        public void PrintWorkerInDateFrame(string start, string end)
        {
            foreach (Worker worker in records)
            {
                if (worker.Ready && worker.IsWithinRange(start, end))
                {
                    Console.WriteLine(worker.WorkerToString());
                }
            }
        }
    }
}
