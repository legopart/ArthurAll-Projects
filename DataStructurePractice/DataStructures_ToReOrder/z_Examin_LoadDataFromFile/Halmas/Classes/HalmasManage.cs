/**
 * מבחן מבנה נתונים
 * 03/01/2022
 **/
using System;
using System.Collections;
using System.IO;
namespace Halmas1.Classes
{
    public class HalmasManage
    {
        private string FILE_NAME = System.IO.Directory.GetCurrentDirectory() + @"\HALMAS.csv";
        public Hashtable halmasHashtable;

        public string PrintEvenMarrageYears() 
        {
            string str = "";
            foreach (Object o in halmasHashtable.Keys)
            {
                Halmas currentHalmas = (Halmas)halmasHashtable[o];
                if (currentHalmas.TotalMarriage % 2 == 0)
                    str += $"{o.GetHashCode()} ";
            }
            return str;
        }
 
        public int GetMariageCompareToNextYear(int thisYear)
        {
            Halmas thisYearHalmas = GetHalmas(thisYear);
            Halmas nextYearHalmas = GetHalmas(thisYear + 1);
            return thisYearHalmas != null && nextYearHalmas != null && thisYearHalmas.MarriagePairs < nextYearHalmas.MarriagePairs
                ? thisYearHalmas.MarriagePairs : 0; //nextYearHalmas.MarriagePairs - thisYearHalmas.MarriagePairs
        }

        public int GetDivorcingCompareToNextYear(int thisYear)
        {
            Halmas thisYearHalmas = GetHalmas(thisYear);
            Halmas nextYearHalmas = GetHalmas(thisYear + 1);
            return thisYearHalmas != null && nextYearHalmas != null && thisYearHalmas.DivorcePairs < nextYearHalmas.DivorcePairs
                ? thisYearHalmas.DivorcePairs : 0; //nextYearHalmas.DivorcePairs - thisYearHalmas.DivorcePairs
        }

        public Halmas GetHalmas(int requiredYear) 
            => halmasHashtable.Contains(requiredYear) ? (Halmas)halmasHashtable[requiredYear] : null;

        public void LoadFromFile()
        {
            Hashtable hashtable = new Hashtable();
            try
            {
                string[] fileContent = File.ReadAllLines(FILE_NAME);
                for (int i = 0; i < fileContent.Length; i++)
                {
                    string cardData = fileContent[i];
                    string[] oneRecord = cardData.Split(',');
                    int year = Int32.Parse(oneRecord[0]);
                    int maryMan = Int32.Parse(oneRecord[1]);
                    int maryWoman = Int32.Parse(oneRecord[2]);
                    int devorceMan = Int32.Parse(oneRecord[3]);
                    int devorceWoman = Int32.Parse(oneRecord[4]);
                    Halmas currentHalmas = new Halmas(maryMan, maryWoman, devorceMan, devorceWoman);
                    hashtable.Add(year, currentHalmas);
                }
            }
            catch (Exception ex) { Console.WriteLine("Error with file loading"); }
            halmasHashtable = hashtable;
        }

    }
}