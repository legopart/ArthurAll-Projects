using System;
using System.Windows.Forms;

namespace MySQL_MongoDB_Cars_StudentsNet4_7
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MySQL_MongoDB_WinForm());
        }
    }
}
