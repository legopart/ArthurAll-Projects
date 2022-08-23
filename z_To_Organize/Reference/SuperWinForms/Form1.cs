using System;

namespace SuperWinForms
{
    public partial class Form1 : Form
    {

        private int x = 5;
        private int y = 6;

        private EventInit eventInit = new EventInit(1, 1, 2);   //inc by, start, +*- by


        public Form1()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            DeligateFuncs.CalcMathFunc Add = DeligateFuncs.Add;
            txtResult.Text = DeligateFuncs.CalcRequest(Add, x, y).ToString();

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            DeligateFuncs.CalcMathFunc Multiple = DeligateFuncs.Multiple;
            txtResult.Text = DeligateFuncs.CalcRequest(Multiple, x, y).ToString();
        }


        private void btnEventAdd_Click(object sender, EventArgs e)
        {
            EventClass1 eventClass1 = new EventClass1();
            eventInit.ClassEvent += eventClass1.Class1Add;
        }

        private void btnEventMult_Click(object sender, EventArgs e)
        {
            EventClass2 eventClass2 = new EventClass2();
            eventInit.ClassEvent += eventClass2.Class2Mult;
        }

        private void btnEventDecrese_Click(object sender, EventArgs e)
        {
            EventClass3 eventClass3 = new EventClass3();
            eventInit.ClassEvent += eventClass3.Class3Delete;
        }

        private void btnRunEvent_Click(object sender, EventArgs e)
        {
            eventInit.Run();
            txtCount.Text = EventInit.inc.ToString();
            txtResult.Text = EventInit.value.ToString();
            lblEventActions.Text = EventInit.str;
            //reset after each run
            EventClassReset eventClassReset = new EventClassReset();
            eventInit.ClassEvent += eventClassReset.ClassReset;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEventReset_Click(object sender, EventArgs e)
        {
            //total reset
            EventClassReset eventClassReset = new EventClassReset();
            eventInit.ClassEvent += eventClassReset.ClassReset;
            eventInit.Run();
            txtCount.Text = EventInit.inc.ToString();
            txtResult.Text = EventInit.value.ToString();
            lblEventActions.Text = EventInit.str;
        }
    }
}