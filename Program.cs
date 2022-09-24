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

            if ((Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers", Application.ExecutablePath, null) == null))
            {

                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers", Application.ExecutablePath, "HIGHDPIAWARE");
                Application.Restart();
                Environment.Exit(0);

                return;
            }


            Application.Run(new Form1());


        }
    }
}