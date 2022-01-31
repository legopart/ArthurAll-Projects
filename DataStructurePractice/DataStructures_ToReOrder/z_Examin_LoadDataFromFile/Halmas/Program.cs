using System;
using Halmas1.Classes;
namespace Halmas1
{
    public class Program
    {
        static void Main(string[] args)
        {
            HalmasManage halmasManage = new HalmasManage();
            Console.WriteLine("Halmas data:");
            Console.WriteLine("Please enter the year:");
            try
            {
                int requiredYear = Int32.Parse(Console.ReadLine());
                halmasManage.LoadFromFile();
                Halmas currentHalmas = (Halmas)halmasManage.halmasHashtable[requiredYear];// halmasManage.GetHalmas(requiredYear);
                if (currentHalmas != null)
                {
                    Console.WriteLine($"For year {requiredYear}:");
                    Console.WriteLine($"\ta) Total marriage this year:  {currentHalmas.TotalMarriage}");
                    Console.WriteLine($"\tb) The most married this year are:  {currentHalmas.MustMarried}");
                    Console.WriteLine($"\tc) Total divorcing this year:  {currentHalmas.TotalDivorcing}");
                    int getMariageCompareToNextYear = halmasManage.GetMariageCompareToNextYear(requiredYear);
                    Console.WriteLine($"\td) Compare pairs mariage to next year, if lower return this year marriage pairs: {(getMariageCompareToNextYear > 0 ? $"{getMariageCompareToNextYear}" : $"No returned data")}");
                    int getDivorcingCompareToNextYear = halmasManage.GetDivorcingCompareToNextYear(requiredYear);
                    Console.WriteLine($"\te) Compare pairs divorcing to next year, if lower return this year divorcing pairs: {(getDivorcingCompareToNextYear > 0 ? $"{getDivorcingCompareToNextYear}" : $"No returned data")}");
                    Console.WriteLine($"\tf) The even total marriages years print: {halmasManage.PrintEvenMarrageYears()}");
                }
            }
            catch (Exception ex) { Console.WriteLine("Error with entered/ received value"); }
            Console.WriteLine("Thank you =D");
        }
    }
}
