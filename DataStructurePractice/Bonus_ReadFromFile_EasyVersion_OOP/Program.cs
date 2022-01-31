using System;

namespace Bonus_ReadFromFile_EasyVersion_OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            SchoolsInYear schoolInYear = new SchoolsInYear();

            Console.WriteLine("Please enter the year:");
            Console.WriteLine("(Receive Numbers of school in this year)");
            try
            {
                int requiredYear = Int32.Parse(Console.ReadLine());
                schoolInYear.LoadFromFile();
                schoolInYear.getSchoolsInYear(requiredYear);
                schoolInYear.getAvarage(requiredYear);
            }
            catch (Exception ex) { Console.WriteLine("Error with entered/ received value"); }
        }
    }
}
