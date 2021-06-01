using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace ManageEdge
{
    public partial class EditAccount : Form
    {

        public static string ID;
        public EditAccount()
        {
            InitializeComponent();
            VisibleForm("1");
            this.Text = "Editar contas";

        }
        private void carregarEdit_Click(object sender, EventArgs e)
        {

            try
            {
                VisibleForm("0");

                this.user.Enabled = false;
                this.hwidBox.Enabled = false;
                this.ipBox.Enabled = false;
                saveAccount.Visible = true;

                using (var conn = new NpgsqlConnection(Settings.connpgpb))
                {
                    conn.Open();

                    using (var command = new NpgsqlCommand("SELECT * FROM accounts WHERE login='" + user.Text + "'", conn))
                    {

                        var reader = command.ExecuteReader();
                        reader.Read();

                        goldAccount.Text = reader.GetInt32(7).ToString();
                        playerNameAccount.Text = reader.GetString(3);
                        emailAccount.Text = reader.GetString(19);
                        moneyAccount.Text = reader.GetInt32(21).ToString();
                        acessLevelAccount.Text = reader.GetInt32(17).ToString();
                        hwidBox.Text = reader.GetString(63);
                        ipBox.Text = reader.GetString(18);

                    }

                    this.Text = "Editando conta " + user.Text;
                    conn.Close();
                }
            }

            catch (NpgsqlException ex)
            {
                VisibleForm("1");
                this.user.Enabled = true;
                saveAccount.Visible = false;
                MessageBox.Show("Error [" + ex.ErrorCode + "] - " + ex.ColumnName + "", this.Text = "Error Code [002]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                VisibleForm("1");
                this.user.Enabled = true;
                saveAccount.Visible = false;

                if (ex.GetType().FullName == "System.InvalidOperationException")
                {
                    MessageBox.Show("Não foi possível localizar a conta.", this.Text = "Error Code [001]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    MessageBox.Show("Error \n [" + ex.GetType().FullName + "]", this.Text = "Error Code [001]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveAccount_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connpg = new NpgsqlConnection(Settings.connpgpb);
            connpg.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connpg;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("UPDATE accounts SET player_name = '" + playerNameAccount.Text + "', email = '" + emailAccount.Text + "', money = '" + moneyAccount.Text + "', gp = '" + goldAccount.Text + "', access_level = '" + acessLevelAccount.Text + "' WHERE login = '{0}'", user.Text);

            int RowsCount = cmd.ExecuteNonQuery();

            if (RowsCount == 0)
            {
                MessageBox.Show("Erro ao salvar dados, tente novamente.", this.Text = "Error Code [002]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Conta salva com successo.", this.Text = "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            connpg.Close();
            this.Close();
        }

        public void VisibleForm(string mode)
        {

            if (mode == "1")
            {
                this.playerNameAccount.Visible = false;
                this.nickText.Visible = false;

                this.emailText.Visible = false;
                this.emailAccount.Visible = false;

                this.moneyText.Visible = false;
                this.moneyAccount.Visible = false;

                this.goldText.Visible = false;
                this.goldAccount.Visible = false;

                this.acessLevelAccount.Visible = false;
                this.acessText.Visible = false;

                this.hwidBox.Visible = false;
                this.hwidText.Visible = false;

                this.ipBox.Visible = false;
                this.ipText.Visible = false;
            }
            else
            {
                this.playerNameAccount.Visible = true;
                this.nickText.Visible = true;

                this.emailText.Visible = true;
                this.emailAccount.Visible = true;

                this.moneyText.Visible = true;
                this.moneyAccount.Visible = true;

                this.goldText.Visible = true;
                this.goldAccount.Visible = true;

                this.acessLevelAccount.Visible = true;
                this.acessText.Visible = true;

                this.hwidBox.Visible = true;
                this.hwidText.Visible = true;

                this.ipBox.Visible = true;
                this.ipText.Visible = true;
            }
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {

        }

        public void user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
