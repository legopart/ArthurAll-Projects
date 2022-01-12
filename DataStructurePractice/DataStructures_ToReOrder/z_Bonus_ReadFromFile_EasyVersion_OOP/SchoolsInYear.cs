using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.z_Bonus_ReadFromFile_EasyVersion_OOP
{
    public class SchoolsInYear
    {
        private string FILE_NAME = System.IO.Directory.GetCurrentDirectory() + @"\z_Bonus_ReadFromFile_EasyVersion_OOP\SCHOOLS1.csv";
        private Hashtable schoolsPerYearHashtable;

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
                    int schools = Int32.Parse(oneRecord[1]);
                    hashtable.Add(year, schools);
                }
            }
            catch (Exception ex) { Console.WriteLine("Error with file loading"); }
            schoolsPerYearHashtable = hashtable;
        }

        public int getSchoolsInYear(int requiredYear)
        {
            if (schoolsPerYearHashtable.Contains(requiredYear))
            {
                int schoolsInYear = (int)schoolsPerYearHashtable[requiredYear];
                Console.WriteLine($"The number of schools in year {requiredYear}:");
                Console.WriteLine(schoolsInYear);
                return schoolsInYear;
            }
            Console.WriteLine($"There in no schools (0) in year: {requiredYear}");
            return 0;
        }

        public double getAvarage(int requiredYear)
        {
            int countYearsAwailable = 0;
            int countSchools = 0;
            for (int i = requiredYear - 5; i <= requiredYear; i++)
            {
                if (schoolsPerYearHashtable.Contains(i))
                {
                    countSchools += (int)schoolsPerYearHashtable[i];
                    countYearsAwailable++;
                    // Console.WriteLine(i + " -> " + (int)schoolsPerYearHashtable[i]);
                }
            }
            if (countYearsAwailable == 0) countYearsAwailable = 1;
            double avarage = (double)countSchools / countYearsAwailable;
            Console.WriteLine($"for last 5 years {requiredYear - 5} -> {requiredYear} the average number of schools is:");
            Console.WriteLine(avarage);
            return avarage;
        }
    }
}
