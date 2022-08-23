using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator.Classes
{
    internal static class BasicProgramming
    {
        public static int WhileExample(int sum = 0)
        {
            int num = 10;
            while (num < 10)
            {
                sum += num;
                num++;
            }
            return sum;
        }

        public static int DoWhileExample(int sum = 0)
        {
            int num = 10;
            do
            {
                sum += num;
                num++;
            } while (num < 10);
            return sum;
        }

        public static List<string> ForeachExample()
        {
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Grape");
            fruits.Add("Passionfruit");
            fruits.Add("Lemon");

            return fruits;
        }

        public static int CalculateSumOfNumbersTill(int tillNumber)
        {
            int sum = 0;
            for (int i = 0; i < tillNumber; i++)
            {
                sum = sum + i;
            }

            return sum;
        }

        public static string IfExample()
        {
            bool IsSunday = DateTime.Today.DayOfWeek == DayOfWeek.Sunday;
            if (IsSunday)
            {
                return("Sunday");
            }
            else
            {
                return("Not sunday");
            }
        }
    }
}
