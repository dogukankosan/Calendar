using System;
using System.Windows.Forms;

namespace Calendar
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.frm_Home());
        }
    }
}
