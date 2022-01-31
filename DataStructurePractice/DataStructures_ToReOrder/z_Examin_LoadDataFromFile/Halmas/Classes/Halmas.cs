/**
 * מבחן מבנה נתונים
 * 03/01/2022
 **/
namespace Halmas1.Classes
{
    public class Halmas
    {
        private int MarryMen { get; }
        private int MarryWomen { get;  }
        private int DivorceMan { get; }
        private int DivorceWoman { get; }

        public int DivorcePairs { get; }
        public int MarriagePairs { get; }
        public int TotalDivorcing { get; }
        public int TotalMarriage { get; }
        public string MustMarried { get; }

        public Halmas(int marryMen, int marryWomen, int devorceMan, int devorceWoman) 
        {
            MarryMen = marryMen;
            MarryWomen = marryWomen;
            DivorceMan = devorceMan;
            DivorceWoman = devorceWoman;
            DivorcePairs = DivorceMan > DivorceWoman ? DivorceWoman : DivorceMan;
            MarriagePairs = MarryMen > MarryWomen ? MarryWomen : MarryMen;
            TotalDivorcing = DivorceMan + DivorceWoman;
            TotalMarriage = MarryWomen + MarryMen;
            MustMarried = MarryMen > MarryWomen ? "Men" : (MarryMen < MarryWomen ? "Women" : "Equal");
        }

    }
}
