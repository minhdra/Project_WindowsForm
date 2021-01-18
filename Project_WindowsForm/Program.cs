using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_WindowsForm.TH1;

namespace Project_WindowsForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Bai1_TH1());
            //Application.Run(new Bai2_TH1());
            Application.Run(new Bai3_TH1());
        }
    }
}
