using System;
using System.IO;
using System.Windows.Forms;

namespace ManageEdge
{
    public static class Program
    {
        public static string IPAdress;
        public static string hwid;
        public static string City, RegionCode;
        public static string token1;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FileSettings();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Entry());
        }
        private static void FileSettings()
        {
            string path = @"Configs/Settings.ini";
            string dir = @"Configs";

            try
            {
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);

                    if (!File.Exists(path))
                    {
                        var myFile = File.Create(path);
                        myFile.Close();

                        string[] configs = { "[Settings]", "HOST=localhost", "DB=postgres", "USER=postgres", "PASS=1234", "PORT=5432" };
                        File.WriteAllLines(path, configs);
                    }
                }


            }
            catch (IOException)
            {
                MessageBox.Show("[001] Configurações invalidas!");
                Application.Exit();
            }
        }
    }
}
