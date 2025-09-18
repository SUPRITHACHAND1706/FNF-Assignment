using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Assignment6
    {
        static bool isValidDate(int year, int month, int day)
        {
            if (month < 1 || month > 12)
                return false;

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (month == 2 && IsLeapYear(year))
                daysInMonth[1] = 29;

            if (day < 1 || day > daysInMonth[month - 1])
                return false;

            return true;
        }

        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter year:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter month (1-12):");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter day:");
            int day = int.Parse(Console.ReadLine());

            bool result = isValidDate(year, month, day);

            if (result)
                Console.WriteLine("The date is VALID.");
            else
                Console.WriteLine("The date is INVALID.");
        }
    }
}
