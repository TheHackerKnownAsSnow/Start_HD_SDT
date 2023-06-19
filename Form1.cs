using MaterialSkin;
using MaterialSkin.Controls;

using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;
using Microsoft.Win32;

namespace Start_HD_SDT_1._3
{
    
    
     
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public string flashFile = Settings.Default.flash;
        public string loaderFolder = Settings.Default.loader;
        public int processorCount = (System.Environment.ProcessorCount - 1);

        


        public class Cpus
        {
            public static long[] myCpus =
            {
                0x0000000000000001,
                0x0000000000000003,
                0x0000000000000007,
                0x000000000000000F,
                0x000000000000001F,
                0x000000000000003F,
                0x000000000000007F,
                0x00000000000000FF,
                0x00000000000001FF,
                0x00000000000003FF,
                0x00000000000007FF,
                0x0000000000000FFF,
                0x0000000000001FFF,
                0x0000000000003FFF,
                0x0000000000007FFF,
                0x000000000000FFFF,
                0x000000000001FFFF,
                0x000000000003FFFF,
                0x000000000007FFFF,
                0x00000000000FFFFF,
                0x00000000001FFFFF,
                0x00000000003FFFFF,
                0x00000000007FFFFF,
                0x0000000000FFFFFF,
                0x0000000001FFFFFF,
                0x0000000003FFFFFF,
                0x0000000007FFFFFF,
                0x000000000FFFFFFF,
                0x000000001FFFFFFF,
                0x000000003FFFFFFF,
                0x000000007FFFFFFF,
                0x00000000FFFFFFFF
            };
        }

        class Window
        {

            public static Process flashWindow;

        }
        
        public Form1()
        {
            InitializeComponent();
            SystemEvents.DisplaySettingsChanged += new EventHandler(SystemEvents_DisplaySettingsChanged);
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Indigo200, MaterialSkin.TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            this.Width = (materialAffinityComboBox.Width * 2) + 80;
            this.Height = materialAffinityComboBox.Height * 7;

            materialAffinityComboBox.Location = new System.Drawing.Point((materialTabControl1.Width / 3) - (materialAffinityComboBox.Width / 2), materialAffinityComboBox.Height);
            materialResolutionComboBox.Location = new System.Drawing.Point(materialTabControl1.Width / 3 - (materialResolutionComboBox.Width / 2), (materialAffinityComboBox.Height + 48));

            materialCheckbox1.Location = new System.Drawing.Point((materialTabControl1.Width / 3) - (materialAffinityComboBox.Width / 2) + materialAffinityComboBox.Width + 16, materialAffinityComboBox.Height);
            materialCheckbox2.Location = new System.Drawing.Point((materialTabControl1.Width / 3) - (materialAffinityComboBox.Width / 2) + materialAffinityComboBox.Width + 16, materialAffinityComboBox.Height + 48);
            materialButton2.Location = new System.Drawing.Point((materialTabControl1.Width / 3 - (materialResolutionComboBox.Width / 2)) + materialResolutionComboBox.Width + 16, materialAffinityComboBox.Height + 96);

            materialResolutionComboBox.SelectedIndex = Settings.Default.resolution;

            materialButton4.Location = new System.Drawing.Point((tabPage1.Width / 2) - (materialButton4.Width/2), (tabPage1.Height / 7));
            materialButton5.Location = new System.Drawing.Point((tabPage1.Width / 2) - (materialButton5.Width / 2), (tabPage1.Height / 7) + 48);
            materialButton6.Location = new System.Drawing.Point((tabPage1.Width / 2) - (materialButton6.Width / 2), (tabPage1.Height / 7) + 96);

            if (Settings.Default.affinity == -1)

            {
                Settings.Default.affinity = System.Environment.ProcessorCount - 1;
            }



            if (Settings.Default.loader == "0")

            {
                Settings.Default.loader = AppDomain.CurrentDomain.BaseDirectory;
                loaderFolder = Settings.Default.loader;
                Settings.Default.loader = loaderFolder;
            }


            materialAffinityComboBox.SelectedIndex = Settings.Default.affinity;

            materialCheckbox1.Checked = Settings.Default.priority;
            materialCheckbox2.Checked = Settings.Default.DpiAware;

            Settings.Default.Save();

            DrawerIsOpen = true;
            DrawerIsOpen = false;

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            try
            {
                MoveWindowToCenter();
            }
            catch
            {

            }

        }


        //test

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        const uint SWP_NOSIZE = 0x0001;
        const uint SWP_NOZORDER = 0x0004;

        private static Size GetScreenSize() => new Size(GetSystemMetrics(0), GetSystemMetrics(1));


        private struct Size
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public Size(int width, int height)
            {
                Width = width;
                Height = height;
            }
        }

        [DllImport("User32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        private static extern int GetSystemMetrics(int nIndex);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowRect(HandleRef hWnd, out Rect lpRect);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int Width, int Height, bool Repaint);


        [StructLayout(LayoutKind.Sequential)]
        private struct Rect
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        private static Size GetWindowSize(IntPtr window)
        {
            if (!GetWindowRect(new HandleRef(null, window), out Rect rect))
                throw new Exception("Unable to get window rect!");

            int width = rect.Right - rect.Left;
            int height = rect.Bottom - rect.Top;

            return new Size(width, height);
        }

        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        public enum DeviceCap
        {
            VERTRES = 10,
            DESKTOPVERTRES = 117,

            // http://pinvoke.net/default.aspx/gdi32/GetDeviceCaps.html
        }

        private float getScalingFactor()
        {
            Graphics g = Graphics.FromHwnd(IntPtr.Zero);
            IntPtr desktop = g.GetHdc();
            int LogicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.VERTRES);
            int PhysicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.DESKTOPVERTRES);

            float ScreenScalingFactor = (float)PhysicalScreenHeight / (float)LogicalScreenHeight;

            return ScreenScalingFactor; // 1.25 = 125%
        }
        public static int GetWindowsScaling()
        {

            int DPI = Int32.Parse((string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ThemeManager","LastLoadedDPI", "96"));
            var currentDPI = (int)Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LogPixels", 96);
            //var scale = 96 / (float)currentDPI;

            if (System.OperatingSystem.IsWindowsVersionAtLeast(10,0,22000,1))
            {
                return DPI;
            }
            else if ((System.OperatingSystem.IsWindowsVersionAtLeast(10)))
            {
                return currentDPI;
            }
            MessageBox.Show("Windows 7 is not supported, Error");
            return 0;
            
        }

        public void MoveWindowToCenter()
        {

            System.Threading.Thread.Sleep(1000);
            IntPtr window = new IntPtr (0);
            try
            {
                window = Window.flashWindow.MainWindowHandle;
            }
            catch
            {
                
                return;
            }

            


            if (window == IntPtr.Zero)
                throw new Exception("Couldn't find a window to center!");

            Size screenSize = GetScreenSize();
            Size windowSize = GetWindowSize(window);

            var xxx = 16;

            var yyy = 59;

            int t = GetWindowsScaling();
            string g = t.ToString();

            //System.Windows.Forms.MessageBox.Show(g);

            switch (GetWindowsScaling())
            {
                case (int)96:
                    xxx = 16;
                    yyy = 59;
                    Settings.Default.scale = 100;
                    break;
                case (int)12:
                    xxx += 2;
                    yyy += 23;
                    Settings.Default.scale = 125;
                    break;
                case (int)144:
                    xxx += 6;
                    yyy += 27;
                    Settings.Default.scale = 150;
                    break;
                case (int)192:
                    xxx += 8;
                    yyy += 39;
                    Settings.Default.scale = 175;
                    break;
                case (int)240:
                    xxx += 10;
                    yyy += 51;
                    Settings.Default.scale = 200;
                    break;
                default:
                    xxx = 16;
                    yyy = 59;
                    Settings.Default.scale = 0;
                    System.Windows.Forms.MessageBox.Show("This scaling not suppoirted");
                    break;
            }

            int[] my2DResX = new int[] { 700 + xxx, 1400 + xxx, 1024 + xxx, 1152 + xxx, 1280 + xxx, 1366 + xxx, 1600 + xxx, 1920 + xxx, 2560 + xxx };

            int[] my2DResY = new int[] { 600 + yyy, 1200 + yyy, 576 + yyy, 648 + yyy, 720 + yyy, 768 + yyy, 900 + yyy, 1080 + yyy, 1440 + yyy };




            int x = (screenSize.Width - my2DResX[materialResolutionComboBox.SelectedIndex]) / 2;
            int y = (screenSize.Height - my2DResY[materialResolutionComboBox.SelectedIndex]) / 2;
            //Thread.Sleep(500);
            MoveWindow(window, x, y, my2DResX[materialResolutionComboBox.SelectedIndex], my2DResY[materialResolutionComboBox.SelectedIndex], true);
            //Thread.Sleep(500);
            SetWindowPos(window, IntPtr.Zero, x, y, 0, 0, SWP_NOSIZE | SWP_NOZORDER);

            Settings.Default.resolution = materialResolutionComboBox.SelectedIndex;
            Settings.Default.Save();

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {


            if (materialAffinityComboBox.SelectedIndex > System.Environment.ProcessorCount - 1)
            {
                materialAffinityComboBox.SelectedIndex = System.Environment.ProcessorCount - 1;

                materialAffinityComboBox.Focus();

            }

            if (!(Window.flashWindow == null))
            {
                if (!(Window.flashWindow.HasExited))

                {

                    Window.flashWindow.Kill();
                    Window.flashWindow.WaitForExit();

                }



            }


            /*
            Process[] flash = Process.GetProcessesByName("flashplayer_10_3r183_90_win_sa");
            if (flash.Length >= 1)
                foreach (Process process in flash)
                {
                    process.Kill();
                }
            */

            if (!File.Exists(loaderFolder + "/Loader.swf"))
            {
                System.Windows.Forms.MessageBox.Show("Can't Find Loader.swf");
                return;
            }

            try
            {
                //MessageBox.Show(loaderFolder);
                Window.flashWindow = Process.Start(flashFile, loaderFolder + "/Loader.swf");
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Can't Find Flashplayer");
                return;
            }

            int cpus = materialAffinityComboBox.SelectedIndex;
            long AffinityMask = (long)Window.flashWindow.ProcessorAffinity;

            AffinityMask &= Cpus.myCpus[cpus];

            if (materialCheckbox1.Checked)
            {
                Window.flashWindow.PriorityClass = ProcessPriorityClass.High;
            }
            Window.flashWindow.ProcessorAffinity = (IntPtr)AffinityMask;

            MoveWindowToCenter();
        }

       


        private void materialButton3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Flash Player: " + Settings.Default.flash + "\n" + "Loader Location: " + Settings.Default.loader + "\n" + "Scale: " + Settings.Default.scale, "Settings", MessageBoxButtons.OK);

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog setFlash = new System.Windows.Forms.OpenFileDialog();

            if (setFlash.ShowDialog() == DialogResult.OK)
            {
                flashFile = setFlash.FileName;
                Settings.Default.flash = setFlash.FileName;
                Settings.Default.Save();
            }
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog setLoader = new FolderBrowserDialog();


            if (setLoader.ShowDialog() == DialogResult.OK)
            {
                loaderFolder = setLoader.SelectedPath;
                Settings.Default.loader = setLoader.SelectedPath;
                Settings.Default.Save();
            }
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            var reset = System.Windows.Forms.MessageBox.Show("Reset settings?", "Are you sure?", MessageBoxButtons.OKCancel);
            if (reset == DialogResult.OK)
            {
                Settings.Default.Reset();
                flashFile = Settings.Default.flash;
                //loaderFolder = Properties.Settings.Default.loader;

                Settings.Default.loader = AppDomain.CurrentDomain.BaseDirectory;
                loaderFolder = Settings.Default.loader;
                Settings.Default.loader = loaderFolder;

            }
        }

        private void materialAffinityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            Settings.Default.affinity = materialAffinityComboBox.SelectedIndex;

            Settings.Default.Save();

           }

        private void materialResolutionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.resolution = materialResolutionComboBox.SelectedIndex;

        }

        private void materialAffinityComboBox_TextChanged(object sender, EventArgs e)
        {
           
            
        }
       

        private void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
            
           // this.Width = materialAffinityComboBox.Width * 3;
           // this.Height = materialAffinityComboBox.Height * 6;
           //
           // materialAffinityComboBox.Location = new System.Drawing.Point((materialTabControl1.Width / 3) - (materialAffinityComboBox.Width / 2), materialAffinityComboBox.Height);
           // materialResolutionComboBox.Location = new System.Drawing.Point(materialTabControl1.Width / 3 - (materialResolutionComboBox.Width / 2), (materialAffinityComboBox.Height + 48));
           //
           // materialCheckbox1.Location = new System.Drawing.Point((materialTabControl1.Width / 3) - (materialAffinityComboBox.Width / 2) + materialAffinityComboBox.Width + 16, materialAffinityComboBox.Height);
           // materialButton2.Location = new System.Drawing.Point((materialTabControl1.Width / 3 - (materialResolutionComboBox.Width / 2)) + materialResolutionComboBox.Width + 16, materialAffinityComboBox.Height + 48);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void Form1_DpiChangedAfterParent(object sender, EventArgs e)
        {
            //this.Width = materialAffinityComboBox.Width * 3;
            //this.Height = materialAffinityComboBox.Height * 6;
            //
            //materialAffinityComboBox.Location = new System.Drawing.Point((materialTabControl1.Width / 3) - (materialAffinityComboBox.Width / 2), materialAffinityComboBox.Height);
            //materialResolutionComboBox.Location = new System.Drawing.Point(materialTabControl1.Width / 3 - (materialResolutionComboBox.Width / 2), (materialAffinityComboBox.Height + 48));
            //
            //materialCheckbox1.Location = new System.Drawing.Point((materialTabControl1.Width / 3) - (materialAffinityComboBox.Width / 2) + materialAffinityComboBox.Width + 16, materialAffinityComboBox.Height);
            //materialButton2.Location = new System.Drawing.Point((materialTabControl1.Width / 3 - (materialResolutionComboBox.Width / 2)) + materialResolutionComboBox.Width + 16, materialAffinityComboBox.Height + 48);

        }

        private void materialMultiLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MinimumSizeChanged(object sender, EventArgs e)
        {
            //this.Width = materialAffinityComboBox.Width * 3;
            //this.Height = materialAffinityComboBox.Height * 6;
            //
            //materialAffinityComboBox.Location = new System.Drawing.Point((materialTabControl1.Width / 3) - (materialAffinityComboBox.Width / 2), materialAffinityComboBox.Height);
            //materialResolutionComboBox.Location = new System.Drawing.Point(materialTabControl1.Width / 3 - (materialResolutionComboBox.Width / 2), (materialAffinityComboBox.Height + 48));
            //
            //materialCheckbox1.Location = new System.Drawing.Point((materialTabControl1.Width / 3) - (materialAffinityComboBox.Width / 2) + materialAffinityComboBox.Width + 16, materialAffinityComboBox.Height);
            //materialButton2.Location = new System.Drawing.Point((materialTabControl1.Width / 3 - (materialResolutionComboBox.Width / 2)) + materialResolutionComboBox.Width + 16, materialAffinityComboBox.Height + 48);

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            //this.Width = materialAffinityComboBox.Width * 3;
            //this.Height = materialAffinityComboBox.Height * 6;
            //
            //materialAffinityComboBox.Location = new System.Drawing.Point((materialTabControl1.Width / 3) - (materialAffinityComboBox.Width / 2), materialAffinityComboBox.Height);
            //materialResolutionComboBox.Location = new System.Drawing.Point(materialTabControl1.Width / 3 - (materialResolutionComboBox.Width / 2), (materialAffinityComboBox.Height + 48));
            //
            //materialCheckbox1.Location = new System.Drawing.Point((materialTabControl1.Width / 3) - (materialAffinityComboBox.Width / 2) + materialAffinityComboBox.Width + 16, materialAffinityComboBox.Height);
            //materialButton2.Location = new System.Drawing.Point((materialTabControl1.Width / 3 - (materialResolutionComboBox.Width / 2)) + materialResolutionComboBox.Width + 16, materialAffinityComboBox.Height + 48);

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Width = (materialAffinityComboBox.Width * 2) + 80;
            this.Height = materialAffinityComboBox.Height * 7;


            materialButton4.Location = new System.Drawing.Point((tabPage1.Width / 2) - (materialButton4.Width / 2), (tabPage1.Height / 7));
            materialButton5.Location = new System.Drawing.Point((tabPage1.Width / 2) - (materialButton5.Width / 2), (tabPage1.Height / 7) + 48);
            materialButton6.Location = new System.Drawing.Point((tabPage1.Width / 2) - (materialButton6.Width / 2), (tabPage1.Height / 7) + 96);
                                                                                     
            DrawerIsOpen = true;
            DrawerIsOpen = false;

        }

        private void materialTabControl1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_DpiChanged(object sender, DpiChangedEventArgs e)
        {
            this.Width = materialAffinityComboBox.Width * 2;
            this.Height = materialAffinityComboBox.Height * 7;

            materialAffinityComboBox.Location = new System.Drawing.Point((materialTabControl1.Width / 3) - (materialAffinityComboBox.Width / 2), materialAffinityComboBox.Height);
            materialResolutionComboBox.Location = new System.Drawing.Point(materialTabControl1.Width / 3 - (materialResolutionComboBox.Width / 2), (materialAffinityComboBox.Height + 48));

            materialCheckbox1.Location = new System.Drawing.Point((materialTabControl1.Width / 3) - (materialAffinityComboBox.Width / 2) + materialAffinityComboBox.Width + 16, materialAffinityComboBox.Height);
            materialButton2.Location = new System.Drawing.Point((materialTabControl1.Width / 3 - (materialResolutionComboBox.Width / 2)) + materialResolutionComboBox.Width + 16, materialAffinityComboBox.Height + 48);

            materialResolutionComboBox.SelectedIndex = Settings.Default.resolution;


            materialButton4.Location = new System.Drawing.Point((tabPage1.Width / 2) - (materialButton4.Width / 2), (tabPage1.Height / 7));
            materialButton5.Location = new System.Drawing.Point((tabPage1.Width / 2) - (materialButton5.Width / 2), (tabPage1.Height / 7) + 48);
            materialButton6.Location = new System.Drawing.Point((tabPage1.Width / 2) - (materialButton6.Width / 2), (tabPage1.Height / 7) + 96);

        }

        private void materialCheckbox2_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.DpiAware = materialCheckbox2.Checked;
            Settings.Default.Save();

            switch (Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers", Application.ExecutablePath, null))
            {
                case null:
                    if (Settings.Default.DpiAware)
                    {
                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers", Application.ExecutablePath, "HIGHDPIAWARE");
                        MessageBox.Show("Restart required for Dpi changes to take effect", "Message", MessageBoxButtons.OK);
                    }
                    // code block
                    break;
                case "HIGHDPIAWARE":
                    if (!(Settings.Default.DpiAware))
                    {
                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers", Application.ExecutablePath, "DPIUNAWARE");
                        MessageBox.Show("Restart required for Dpi changes to take effect", "Message", MessageBoxButtons.OK);
                    }
                    break;
                case "DPIUNAWARE":
                    // code block
                    if (Settings.Default.DpiAware)
                    {
                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers", Application.ExecutablePath, "HIGHDPIAWARE");
                        MessageBox.Show("Restart required for Dpi changes to take effect", "Message", MessageBoxButtons.OK);
                    }
                    break;
                default:
                    if (Settings.Default.DpiAware)
                    {
                        Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers", Application.ExecutablePath, "HIGHDPIAWARE");
                        MessageBox.Show("Restart required for Dpi changes to take effect", "Message", MessageBoxButtons.OK);
                    }
                    break;


            }

        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}