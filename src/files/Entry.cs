using System;
using System.IO;
using System.Windows.Forms;

namespace ManageEdge
{
    public partial class Entry : Form
    {
        public static string HOST, USER, PASS, DB, PORT;

        public static string PATH = @"Configs/Settings.ini";

        public Entry()
        {
            InitializeComponent();
        }

        private void Entry_Load(object sender, EventArgs e)
        {
            using StreamReader readerHOST = new StreamReader(PATH);
            while (!readerHOST.EndOfStream)
            {
                string str = readerHOST.ReadLine();
                if (str.StartsWith("HOST") && str.Length != 0 && !str.StartsWith(";") && !str.StartsWith("["))
                {
                    string[] split = str.Split('=');
                    hostBox.Text = split[1].ToString();
                }
            }
            readerHOST.Close();

            using StreamReader readerDB = new StreamReader(PATH);
            while (!readerDB.EndOfStream)
            {
                string str = readerDB.ReadLine();
                if (str.StartsWith("DB") && str.Length != 0 && !str.StartsWith(";") && !str.StartsWith("["))
                {
                    string[] split = str.Split('=');
                    dbBox.Text = split[1].ToString();
                }
            }
            readerDB.Close();

            using StreamReader readerUSER = new StreamReader(PATH);
            while (!readerUSER.EndOfStream)
            {
                string str = readerUSER.ReadLine();
                if (str.StartsWith("USER") && str.Length != 0 && !str.StartsWith(";") && !str.StartsWith("["))
                {
                    string[] split = str.Split('=');
                    userBox.Text = split[1].ToString();
                }
            }
            readerUSER.Close();

            using StreamReader readerPASS = new StreamReader(PATH);
            while (!readerPASS.EndOfStream)
            {
                string str = readerPASS.ReadLine();
                if (str.StartsWith("PASS") && str.Length != 0 && !str.StartsWith(";") && !str.StartsWith("["))
                {
                    string[] split = str.Split('=');
                    passBox.Text = split[1].ToString();
                }
            }
            readerPASS.Close();

            using StreamReader readerPORT = new StreamReader(PATH);
            while (!readerPORT.EndOfStream)
            {
                string str = readerPORT.ReadLine();
                if (str.StartsWith("PORT") && str.Length != 0 && !str.StartsWith(";") && !str.StartsWith("["))
                {
                    string[] split = str.Split('=');
                    portBox.Text = split[1].ToString();
                }
            }
            readerPORT.Close();

        }

        public void button1_Click(object sender, EventArgs e)
        {

            HOST = hostBox.Text.ToString();
            USER = userBox.Text;
            PASS = passBox.Text;
            DB = dbBox.Text;
            PORT = portBox.Text;

            string[] configs = { "[Settings]", "HOST="+ HOST +"", "DB="+ DB +"", "USER="+ USER +"", "PASS="+ PASS +"", "PORT="+ PORT +"" };
            File.WriteAllLines(PATH, configs);

            this.Hide();
            var Admin = new Admin();
            Admin.Closed += (s, args) => this.Close();
            Admin.Show();
        }
    }
}
