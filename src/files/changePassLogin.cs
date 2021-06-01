using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace ManageEdge
{
    public partial class changePassLogin : Form
    {
        public changePassLogin()
        {
            InitializeComponent();
            this.Text = "Alterar senha a partir do Login";
            this.saveBtn.Visible = false;
            this.passBox.Visible = false;

            this.hashBox.Visible = false;
            this.hashText.Visible = false;

            this.Size = new System.Drawing.Size(473, 142);
        }

        private void changePassLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.loginBox.Visible = false;
                this.btnSearch.Visible = false;

                this.saveBtn.Visible = true;
                this.passBox.Visible = true;

                this.saveBtn.Text = "Salvar";

                this.Text = "Alterando senha da conta " + this.loginBox.Text;
                
                this.label1.Text = "Nova senha";
                this.label1.Location = new Point(184, 13);

                using (var conn = new NpgsqlConnection(Settings.connpgpb))
                {
                    conn.Open();

                    using (var command = new NpgsqlCommand("SELECT * FROM accounts WHERE login='" + loginBox.Text + "'", conn))
                    {
                        this.Size = new Size(473, 174);
                        this.hashBox.Visible = true;
                        this.hashText.Visible = true;
                        this.hashBox.Enabled = false;

                        var reader = command.ExecuteReader();
                        reader.Read();

                        hashBox.Text = reader.GetString(1);
                    }
                    conn.Close();
                }
            }

            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error [" + ex.ErrorCode + "] - " + ex.ColumnName + "", this.Text = "Error Code [002]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                if (ex.GetType().FullName == "System.InvalidOperationException")
                {
                    MessageBox.Show("Não foi possível localizar a conta.", this.Text = "Error Code [001]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error \n [" + ex.GetType().FullName + "]", this.Text = "Error Code [001]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connpg = new NpgsqlConnection(Settings.connpgpb);
            connpg.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connpg;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = string.Format("UPDATE accounts SET password = '" + Npgsql.EncryptPass(passBox.Text) + "' WHERE login = '"+ loginBox.Text +"'");

            int RowsCount = cmd.ExecuteNonQuery();

            if (RowsCount == 0)
            {
                MessageBox.Show("Erro ao salvar conta, tente novamente!.", this.Text = "Error Code [002]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Senha alterada com sucesso.", this.Text = "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            connpg.Close();
            this.Close();
        }
    }
}
