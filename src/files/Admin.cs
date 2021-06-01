using Npgsql;
using System;
using System.IO;
using System.Windows.Forms;
using a;

namespace ManageEdge
{
    public partial class Admin : Form
    {
        public object UserInput { get; private set; }
        Functions Funcs = new Functions();
        public Admin()
        {

            InitializeComponent();
                try
                {
                    NpgsqlConnection connpg = new NpgsqlConnection(Settings.connpgpb);
                    connpg.Open();
                    NpgsqlCommand command = new NpgsqlCommand("SELECT COUNT(*) FROM accounts", connpg);
                    Int64 accounts = (Int64)command.ExecuteScalar();

                    NpgsqlCommand command1 = new NpgsqlCommand("SELECT COUNT(*) FROM ban_hwid", connpg);
                    Int64 bans_hwid = (Int64)command1.ExecuteScalar();

                    this.Text = "Total de contas: " + accounts.ToString() + " | Banimentos (HWID): " + bans_hwid.ToString() + "";
                    connpg.Close();
                }
                catch (NpgsqlException msqle)
                {
                    MessageBox.Show(msqle.Message, "Error", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error,
                                       MessageBoxDefaultButton.Button1, 0);
                    Application.Restart();

            }
            connectionTab();
        }
        private void Admin_Load(object sender, EventArgs e)
        {

        }
        private void editAccountBtn_Click(object sender, EventArgs e)
        {
            Form EditAccount = new EditAccount();
            EditAccount.ShowDialog();
        }

        private void getAccountIPBtn_Click(object sender, EventArgs e)
        {
            Form getAccountIP = new getAccountIP();
            getAccountIP.ShowDialog();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void connectionTab()
        {

            using StreamReader readerHOST = new StreamReader(Settings.PATH);
            while (!readerHOST.EndOfStream)
            {
                string str = readerHOST.ReadLine();
                if (str.StartsWith("HOST") && str.Length != 0 && !str.StartsWith(";") && !str.StartsWith("["))
                {
                    string[] split = str.Split('=');
                    this.hostCntBox.Text = split[1].ToString();
                }
            }

            readerHOST.Close();

            using StreamReader readerUSER = new StreamReader(Settings.PATH);
            while (!readerUSER.EndOfStream)
            {
                string str = readerUSER.ReadLine();
                if (str.StartsWith("USER") && str.Length != 0 && !str.StartsWith(";") && !str.StartsWith("["))
                {
                    string[] split = str.Split('=');
                    this.userCntBox.Text = split[1].ToString();
                }
            }
            readerUSER.Close();

            using StreamReader readerPASS = new StreamReader(Settings.PATH);
            while (!readerPASS.EndOfStream)
            {
                string str = readerPASS.ReadLine();
                if (str.StartsWith("PASS") && str.Length != 0 && !str.StartsWith(";") && !str.StartsWith("["))
                {
                    string[] split = str.Split('=');
                    this.passCntBox.Text = split[1].ToString();
                }
            }
            readerPASS.Close();

            using StreamReader readerDB = new StreamReader(Settings.PATH);
            while (!readerDB.EndOfStream)
            {
                string str = readerDB.ReadLine();
                if (str.StartsWith("DB") && str.Length != 0 && !str.StartsWith(";") && !str.StartsWith("["))
                {
                    string[] split = str.Split('=');
                    this.dbCntBox.Text = split[1].ToString();
                }
            }
            readerDB.Close();

            using StreamReader readerPORT = new StreamReader(Settings.PATH);
            while (!readerPORT.EndOfStream)
            {
                string str = readerPORT.ReadLine();
                if (str.StartsWith("PORT") && str.Length != 0 && !str.StartsWith(";") && !str.StartsWith("["))
                {
                    string[] split = str.Split('=');
                    this.portCntBox.Text = split[1].ToString();
                }
            }
            readerPORT.Close();
        }

        private void connectionBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection connpg = new NpgsqlConnection("Server=" + hostCntBox.Text + ";Port=" + portCntBox.Text + ";User Id=" + userCntBox.Text + ";Password=" + passCntBox.Text + ";Database=" + dbCntBox.Text + ";");
                connpg.Open();
                MessageBox.Show("Conexão funcionando!");
            }
            catch (NpgsqlException msqle)
            {
                MessageBox.Show("Erro de acesso ao Npgsql: " + msqle.BaseMessage, "Erro");
            }
            finally
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=" + hostCntBox.Text + ";Port=" + portCntBox.Text + ";User Id=" + userCntBox.Text + ";Password=" + passCntBox.Text + ";Database=" + dbCntBox.Text + ";");
                conn.Close();
            }
        }

        public void changePassBtn_Click(object sender, EventArgs e)
        {

            Form changePass = new changePassLogin();
            changePass.ShowDialog();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Funcs.UpdateDB("accounts", "access_launcher", "0", "Access Launcher resestado com sucesso");
        }

        private void banHWID_Click(object sender, EventArgs e)
        {
            Form banHwid = new banHwid();
            banHwid.ShowDialog();
            
        }
        public void resetTempBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja resetar a temporada atual?", "Resetar Temporada", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                Funcs.DeleteDB("ban_hwid");
            }
        }
    }
}