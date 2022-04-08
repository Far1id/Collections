using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Student
    {
        public int No { get; set; }
        public string FullName { get; set; }
        Dictionary<string, double> Exams = new Dictionary<string, double>();

        public bool CheckExamByExamName(string examname)
        {
            foreach (var item in Exams)
            {
                if (item.Key == examname)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddExam(string examName, double point)
        {
            if (CheckExamByExamName(examName) == false)
            {
                Exams.Add(examName, point);
            }
        }
        public double GetExamResult(string examName)
        {
            foreach (var item in Exams)
            {
                if (item.Key == examName)
                {
                    return item.Value;
                }
            }
            Console.WriteLine("Bele bir imtahan olmayib.");
            return -1;
        }
        public double GetExamAvg()
        {
            int count = 0;
            double sum = 0;
            foreach (var item in Exams)
            {
                count++;
                sum += item.Value;
            }
            return sum / count;
        }
        public void GetInfo()
        {
            foreach (var item in Exams)
            {
                Console.WriteLine(item.Key + item.Value);
            }
        }
        public void RemoveExamByExamName(string examname)
        {
            foreach (var item in Exams)
            {
                if (item.Key==examname)
                {
                    Exams.Remove(item.Key);
                }
            }
        }
    }
}
