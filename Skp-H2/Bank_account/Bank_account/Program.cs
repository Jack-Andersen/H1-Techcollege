using System;
using System.Windows.Forms;

namespace Bank_account
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Bank_account_form());
        }
    }
}
