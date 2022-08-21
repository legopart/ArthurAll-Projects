using System.Reflection;
using MultyThreadLibrary;
namespace MultyThreadApp
{
    public partial class PrimeCalculator_MultiThread : Form
    {
        public PrimeCalculator_MultiThread()
        {
            InitializeComponent();
        }

        private async /*Task*/ void btnCalculateRange_Click(object sender, EventArgs e)
        {
            long start = long.Parse(txtRangeStart.Text);
            long end = long.Parse(txtRangeEnd.Text);
            // MultiThread Result
            await MultiThread.MultiThread_SetListBox_Async(this, lbxRangeResults ,start, end);
 
        }

    }
}