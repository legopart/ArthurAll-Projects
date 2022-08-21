using System;
using System.Collections;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {

        LottoMgr lottoMgr = new LottoMgr();
        



        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (lottoMgr.Cards.Count == 0) { lottoMgr.LoadFromFile(); }
            label1.Text = "המערכת הותחלה!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lottoMgr.Cards.Count == 0) { lottoMgr.LoadFromFile(); }

            string str = "המספר הגבוה ביותר הוא :";
            str += lottoMgr.getMaxNumber().ToString();
            label1.Text = str;


            /* הדפסה לדוגמה *
            Card? card = (Card) lottoMgr.Cards[3061];

            string str = "";
            byte num = 0;
            for (int i = 0; i < LottoMgr.NUMBERS_IN_CARD; i++) 
            {
           //     num = card.Numbers[i];
                str += card.Numbers[i];
                str += ",";
            }
            str += card.AddNum;
            label1.Text = str;
            /* */

            //    Guid a;
            //    a= Guid.NewGuid();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (lottoMgr.Cards.Count == 0) { lottoMgr.LoadFromFile();}
            if (lottoMgr.MaxNum == 0) { lottoMgr.getMaxNumber(); }
            if (lottoMgr.FrequancyArray == null) lottoMgr.getFrequencyTable();

            label1.Text = "טבלת שכיחויות:";
            richTextBox1.Text = lottoMgr.FrequencyTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lottoMgr.Cards.Count == 0) { lottoMgr.LoadFromFile(); }
            if (lottoMgr.MaxNum == 0) { lottoMgr.getMaxNumber(); }
            if (lottoMgr.FrequancyArray == null) { lottoMgr.getFrequencyTable(); } // להגדיר פונקציה להרצה עם לא נאלל אז יריץ פונקציית הצבה

            int requested = int.Parse(textBox1.Text);
            label3.Text = lottoMgr.FrequancyArray[requested].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}