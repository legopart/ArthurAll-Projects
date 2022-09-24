using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    public class LottoMgr
    {

        //Card[] Cards;
        public Hashtable Cards = new Hashtable();
        public int MaxNum = 0;
        public int[] FrequancyArray;
        public string FrequencyTable = "";

        string FILE_NAME = System.IO.Directory.GetCurrentDirectory()+ @"\Lotto.csv";
        public const int NUMBERS_IN_CARD = 6;


        public string getFrequencyTable()
        {
            FrequancyArray = new int[MaxNum + 1];
            Hashtable hashtable = Cards;

            foreach (Object o in hashtable.Keys)
            {
                Card currCard = (Card)hashtable[o];

                for (byte i = 0; i < LottoMgr.NUMBERS_IN_CARD; i++)
                    FrequancyArray[currCard.Numbers[i]] += 1;
            }

            int j = 0;
            string str = "";
            foreach (int x in FrequancyArray)
            {
                str += j + ":";
                str += x;
                str += " ,";
                j++;
            }
            FrequencyTable = str;
            return str;
        }





        public byte getMaxNumber()
        {

            byte maxNum = 0;
            Hashtable hashtable = Cards;

            foreach (Object o in hashtable.Keys)
            {
                Card currCard = (Card)hashtable[o];
                //לפי חיים
                int arrLast = currCard.Numbers.Length - 1;
                if (currCard.Numbers[arrLast] > maxNum) maxNum = currCard.Numbers[arrLast];
                /* *
                for (int i = 0; i < LottoMgr.NUMBERS_IN_CARD; i++)
                    if (currCard.Numbers[i] > maxNum) maxNum = currCard.Numbers[i];
                /* */
            }

            MaxNum = maxNum;
            return maxNum;
        }

        public void LoadFromFile()
        {
            string[] fileContent = File.ReadAllLines(FILE_NAME); //קורא לפי \r\n
            for (int i = 0; i < fileContent.Length; i++)
            {
                string cardData = fileContent[i];
                string[] oneRecord = cardData.Split(',');
                Card newCard = new Card();
                newCard.Id = Int32.Parse(oneRecord[0]);
                newCard.AddNum = byte.Parse(oneRecord[8]);
                for(int j = 0; j < NUMBERS_IN_CARD; j++) 
                    newCard.Numbers[j] = byte.Parse(oneRecord[j+2]);

                Array.Sort(newCard.Numbers);

                Cards.Add(newCard.Id, newCard);
            }

        }
    }
}
