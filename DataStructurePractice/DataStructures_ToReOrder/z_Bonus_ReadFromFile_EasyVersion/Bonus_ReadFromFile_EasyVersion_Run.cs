using System;
using System.Collections;
using System.IO;

namespace DataStructures.z_Bonus_ReadFromFile_EasyVersion
{
    public struct Bonus_ReadFromFile_EasyVersion_Run
    {
        public static void ProgramRun()
        {
            Hashtable schoolsPerYearHashtable = new Hashtable();
            string FILE_NAME = System.IO.Directory.GetCurrentDirectory() + @"\z_Bonus_ReadFromFile_EasyVersion\SCHOOLS1.csv";

            string[] fileContent = File.ReadAllLines(FILE_NAME);
            for (int i = 0; i < fileContent.Length; i++)
            {
                string cardData = fileContent[i];
                string[] oneRecord = cardData.Split(',');

                int year = Int32.Parse(oneRecord[0]);
                int schools = Int32.Parse(oneRecord[1]);

                schoolsPerYearHashtable.Add(year, schools);
            }

            try
            {
                bool IsSchools = true;

                Console.WriteLine("Please enter the year:");
                Console.WriteLine("(Receive Numbers of school in this year)");
                int requiredYear = Int32.Parse(Console.ReadLine());
                if (schoolsPerYearHashtable.Contains(requiredYear))
                {
                    int schoolsInYear = (int)schoolsPerYearHashtable[requiredYear];
                    Console.WriteLine($"The number of schools in year {requiredYear}:");
                    Console.WriteLine(schoolsInYear);
                }
                else
                {
                    Console.WriteLine($"There in no schools (0) in year: {requiredYear}");
                    IsSchools = false;
                }



                if (IsSchools)
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

                    double avarage = (double)countSchools / countYearsAwailable;
                    Console.WriteLine($"for last 5 years {requiredYear - 5} -> {requiredYear} the average number of schools is:");
                    Console.WriteLine(avarage); 
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error to with entered/ received value");
            }
        }
    }
}