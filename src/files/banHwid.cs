using System;
using Npgsql;
using System.Windows.Forms;

namespace ManageEdge
{
    public partial class banHwid : Form
    {

        public static string hwid;
        public banHwid()
        {
            InitializeComponent();
            this.Text = "Banir HWID";
            this.button1.Visible = false;
        }

        private void banHWID_Load(object sender, EventArgs e)
        {

        }

        public void banHwidBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(Settings.connpgpb))
                {
                    conn.Open();
                    using (var command = new NpgsqlCommand("SELECT * FROM accounts WHERE login='" + hwidBox.Text + "'", conn))
                    {

                        var reader = command.ExecuteReader();
                        reader.Read();

                        string hwid = reader.GetString(63);
                        this.Text = "Banindo o HWID " + hwid;

                        hwidBox.Text = hwid;
                        hwidText.Text = "HWID";

                        this.getHwidBtn.Visible = false;
                        this.button1.Visible = true;

                    }
                    conn.Close();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error [" + ex.ErrorCode + "] - " + ex.ColumnName + "", this.Text = "Error Code [002]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                if (ex.GetType().FullName == "System.InvalidOperationException")
                {
                    MessageBox.Show("Não foi possível localizar a conta.", this.Text = "Error Code [001]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error \n [" + ex.GetType().FullName + "]", this.Text = "Error Code [001]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(Settings.connpgpb))
                {             
                    pgsqlConnection.Open();

                    string cmdInserir = String.Format("INSERT INTO ban_hwid (hwid) VALUES ('"+ hwidBox.Text +"')");

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdInserir, pgsqlConnection))
                    {
                        int rows = pgsqlcommand.ExecuteNonQuery();
                        if (rows == 0)
                            MessageBox.Show("Erro ao tentar adicionar o banimento.", this.Text = "Error Code [005]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Banimento adicionado com sucesso", this.Text = "Sucesso ao aplicar o Banimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                    }

                    pgsqlConnection.Close();
                }
            }
            catch (NpgsqlException ex)
            {
                if (ex.ErrorCode.ToString() == "-2147467259")
                {
                    MessageBox.Show("Já existe um banimento no HWID requisistado.", this.Text = "Error Code [001]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
