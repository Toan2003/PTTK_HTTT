using System;
using System.Windows.Forms;
using WindowsFormsApp2.MH.DuyetHoSoUngTuyen;

namespace WindowsFormsApp2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DSHoSoUngVien());
        }
    }
}
