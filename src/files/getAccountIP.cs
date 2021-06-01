using System;
using System.Drawing;
using System.Windows.Forms;

namespace ManageEdge
{
    public partial class getAccountIP : Form
    {
        public getAccountIP()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(583, 132);
        }

        Npgsql access = new Npgsql();
        public void Entry()
        {
            try
            {
                atualizarExibicao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }
        public void btnExibir_Click(object sender, EventArgs e)
        {
            this.Text = "Procurando contas pelo IP " + this.txtIP.Text;

            this.Size = new System.Drawing.Size(583, 394);
            Screen screen = Screen.FromControl(this);

            Rectangle workingArea = screen.WorkingArea;
            this.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
            };

            try
            {
                atualizarExibicao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void atualizarExibicao()
        {
            dgvFunci.DataSource = access.GetTodosRegistros(txtIP.Text);
        }

        public void limpaTextBox(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c.HasChildren)
                {
                    limpaTextBox(c);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
