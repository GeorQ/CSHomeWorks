using System;
using System.Collections.Generic;
using System.Text;

namespace SixthHW
{
    struct Worker
    {
        public bool Ready { get; set; }
        public int Id { get; set; }
        public DateTime DateOfRecord { get; private set; }
        public string FIO { get; private set; }
        public int Age { get; private set; }
        public int Height { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string PlaceOfBirth { get; private set; }

        public Worker(int id, string fio, int age, int height, string dateOfBirth, string placeOfBirth)
        {
            Id = id;
            DateOfRecord = DateTime.Now;
            FIO = fio;
            Age = age;
            Height = height;
            DateOfBirth = DateTime.Parse(dateOfBirth);
            PlaceOfBirth = placeOfBirth;
            Ready = true;
        }
        
        public Worker(string workerInfo)
        {
            string[] data = workerInfo.Split("#");
            Id = Int32.Parse(data[0]);
            DateOfRecord = DateTime.Parse(data[1]);
            FIO = data[2];
            Age = Int32.Parse(data[3]);
            Height = Int32.Parse(data[4]);
            DateOfBirth = DateTime.Parse(data[5]);
            PlaceOfBirth = data[6];
            Ready = true;
        }

        public string WorkerToString()
        {
            if (PlaceOfBirth.Contains("город"))
            {
                return $"{Id}#{DateOfRecord.ToString("dd.MM.yyyy HH:mm")}#{FIO}#{Age}#{Height}#{DateOfBirth.ToString("dd.MM.yyyy")}#{PlaceOfBirth}";
            }
            return $"{Id}#{DateOfRecord.ToString("dd.MM.yyyy HH:mm")}#{FIO}#{Age}#{Height}#{DateOfBirth.ToString("dd.MM.yyyy")}#город {PlaceOfBirth}";
        }

        public bool IsWithinRange(string startDate, string endDate)
        {
            DateTime start = DateTime.Parse(startDate);
            DateTime end = DateTime.Parse(endDate);
            if (DateTime.Compare(start, DateOfBirth) <= 0 && DateTime.Compare(end, DateOfBirth) >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
