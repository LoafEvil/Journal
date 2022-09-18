using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Student
    {
        static int VisitedCounting(List<int> Journal)
        {
            int S = 0;

            foreach (long i in Journal)
            {
                if (i != 0) S++;
            }

            return S;
        }

        static Dictionary<string, long> Visited(Dictionary<string, List<int>> Journal)
        {
            Dictionary<string, long> VisitedDays = new Dictionary<string, long>();

            foreach (string key in Journal.Keys)
            {
                VisitedDays.Add(key, VisitedCounting(Journal[key]));
            }

            return VisitedDays;
        }

        static double evalAverageCounting(List<int> arr)
        {
            double sum = 0;
            int i = 0;

            foreach (double item in arr)
            {
                if (item != 1)
                {
                    sum += item;
                    if (item != 0) i++;
                }
            }
            return sum / i;
        }

        static Dictionary<string, double> evalAverage(Dictionary<string, List<int>> arr)
        {
            Dictionary<string, double> Average = new Dictionary<string, double>();

            foreach (string key in arr.Keys)
            {
                Average.Add(key, evalAverageCounting(arr[key]));
            }

            return Average;

        }

        static Dictionary<string, double> PercentCounting(Dictionary<string, long> VisitedDays, long Days)
        {
            Dictionary<string, double> Percent = new Dictionary<string, double>();

            foreach (string key in VisitedDays.Keys)
            {
                Percent.Add(key, (100 * (double)VisitedDays[key]) / Days);
            }

            return Percent;
        }

        static int EvaluationProcess(double percent, double average)
        {
            if (0 <= percent && percent < 55)
            {
                percent = 2;
            }
            else if (percent >= 55 && percent < 70)
            {
                percent = 3;
            }
            else if (percent >= 70 && percent < 80)
            {
                percent = 4;
            }
            else
            {
                percent = 5;
            }


            if (0 <= average && average < 2.6)
            {
                average = 2;
            }
            else if (average >= 2.6 && average < 3.6)
            {
                average = 3;
            }
            else if (average >= 3.6 && average < 4.6)
            {
                average = 4;
            }
            else
            {
                average = 5;
            }

            if (average == percent)
            {
                return Convert.ToInt32(average);
            }
            else
            {
                return 0;
            }
        }

        static Dictionary<string, int> Evaluation(Dictionary<string, double> percent, Dictionary<string, double> average)
        {
            Dictionary<string, int> evalFunc = new Dictionary<string, int>();

            foreach (string key in percent.Keys)
            {
                evalFunc.Add(key, EvaluationProcess(percent[key], average[key]));
            }

            return evalFunc;
        }



        public string Name;
        public long Days;
        public Dictionary<string, List<int>> Diary;
        public Dictionary<string, long> VisitedDays;
        public Dictionary<string, double> Average;
        public Dictionary<string, double> Percent;
        public Dictionary<string, int> evalFunc;



        public Student(string Name, long Days, Dictionary<string, List<int>> Diary)
        {
            this.Name = Name;
            this.Days = Days;
            this.Diary = Diary;
            this.VisitedDays = Visited(Diary);
            this.Average = evalAverage(Diary);
            this.Percent = PercentCounting(VisitedDays, Days);

            this.evalFunc = Evaluation(Percent, Average);
        }

        public Dictionary<string, List<int>> Diar
        {
            set
            {
                this.Diary = value;
                this.VisitedDays = Visited(Diary);
                this.Average = evalAverage(Diary);
                this.Percent = PercentCounting(VisitedDays, Days);
            }
        }



    }
}
