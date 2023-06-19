using Microsoft.Win32;

namespace Start_HD_SDT_1._3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();


        [STAThread]
        static void Main()
        {
            SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            

            Application.Run(new Form1());

        }
    }
}