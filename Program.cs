using System;
using System.Collections.Generic;

namespace CheckLeapYear
{
    class Program
    {
        static List<int> LeapYears = new List<int>();
        static List<int> NonLeapYears = new List<int>();

        static int startYear, endYear = 0;
        static void Main(string[] args)
        {
            startYear = GetYear("start");
            endYear = GetYear("end");
            GetLeapYears();
            Console.WriteLine("Between the year {0} to {1}, following are: \n", startYear, endYear);
            Console.WriteLine("Leap Years: [{0}]", string.Join(", ", LeapYears));
            Console.WriteLine("Non Leap Years: [{0}]", string.Join(", ", NonLeapYears));
            Console.ReadKey();
        }
        static void GetLeapYears()
        {
            for (int count = startYear; count <= endYear; count++)
            {
                if (IsLeapYear(count))
                    LeapYears.Add(count);
                else
                    NonLeapYears.Add(count);
            }
        }
        static int GetYear(string s)
        {
            Console.WriteLine("Please enter {0} year: ", s);
            int y = Convert.ToInt32(Console.ReadLine());
            return y;
        }
        static bool IsLeapYear(int y)
        {
            //condition: if year is divisable by 4 and not by 100 => leap year
            //if year is divisable by 4, 100, 400 => leap year
            if (y % 4 == 0)
            {
                if (y % 100 != 0)
                    return true;
                else
                {
                    if (y % 400 == 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }
    }
}
