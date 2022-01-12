using System;
using System.Windows.Forms;

namespace ExamMySQL_MongoDB
{ 
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MySQL_MongoDB_WinForm());
        }
    }
}
