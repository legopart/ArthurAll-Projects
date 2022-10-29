namespace Exercise_04.RomanNumeral
{
    public class RomanNumeral
    {
        Dictionary<int, string> arabicToRoman = new Dictionary<int, string>
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 6, "VI" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
<<<<<<< HEAD

=======
>>>>>>> c80243dc63730473d0560cc27729efc5a42dd724
        };
        Dictionary<string, int> romanToArabic = new Dictionary<string, int>
        {
            { "M", 1000 },
            { "CM", 900 },
            { "D", 500 },
            { "CD", 400 },
            { "C", 100 },
            { "XC", 90 },
            { "L", 50 },
            { "XL", 40 },
            { "X", 10 },
            { "IX", 9 },
            { "VI", 6 },
            { "V", 5 },
            { "IV", 4 },
            { "I", 1 },
        };

        public string ArabicToRoman(int number)
        {
            string romanNumber = "";
            if (number != 0)
                { 
                foreach (int value in arabicToRoman.Keys)
                {
                    while (number >= value)
                    {
                        romanNumber += arabicToRoman[value];
                        number -= value;
                    }
                }
            }
            return romanNumber;
        }

        public int RomanToArabic (string line)
        {
            int arabicNumber = 0;
            string newRomanNumber;

            if (line == "") arabicNumber = 0;
            else if (line.Length == 1) arabicNumber = romanToArabic[line];
            else
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (i < line.Length - 1)
                    {
                        if (line[i] == 'I' && (line[i + 1] == 'V' || line[i + 1] == 'X'))
                        {
                            newRomanNumber = line[i].ToString() + line[i + 1].ToString();
                            i++;
                        }
                        else if (line[i] == 'X' && (line[i + 1] == 'L' || line[i + 1] == 'C'))
                        {
                            newRomanNumber = line[i].ToString() + line[i + 1].ToString();
                            i++;
                        }
                        else if (line[i] == 'C' && (line[i + 1] == 'D' || line[i + 1] == 'M'))
                        {
                            newRomanNumber = line[i].ToString() + line[i + 1].ToString();
                            i++;
                        }
                        else newRomanNumber = line[i].ToString();
                        arabicNumber += romanToArabic[newRomanNumber];
                    }
                    else arabicNumber += romanToArabic[line[i].ToString()];
                }
            }         
            
            return arabicNumber;
        }
    }
}