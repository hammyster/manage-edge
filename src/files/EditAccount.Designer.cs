namespace ManageEdge
{
    partial class EditAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAccount));
            this.acessText = new System.Windows.Forms.Label();
            this.acessLevelAccount = new System.Windows.Forms.TextBox();
            this.goldText = new System.Windows.Forms.Label();
            this.goldAccount = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.Label();
            this.emailAccount = new System.Windows.Forms.TextBox();
            this.nickText = new System.Windows.Forms.Label();
            this.playerNameAccount = new System.Windows.Forms.TextBox();
            this.carregarEdit = new System.Windows.Forms.Button();
            this.moneyText = new System.Windows.Forms.Label();
            this.saveAccount = new System.Windows.Forms.Button();
            this.moneyAccount = new System.Windows.Forms.TextBox();
            this.userText = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.hwidText = new System.Windows.Forms.Label();
            this.ipText = new System.Windows.Forms.Label();
            this.hwidBox = new System.Windows.Forms.TextBox();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // acessText
            // 
            this.acessText.AutoSize = true;
            this.acessText.Location = new System.Drawing.Point(249, 51);
            this.acessText.Name = "acessText";
            this.acessText.Size = new System.Drawing.Size(42, 13);
            this.acessText.TabIndex = 26;
            this.acessText.Text = "Acesso";
            // 
            // acessLevelAccount
            // 
            this.acessLevelAccount.Location = new System.Drawing.Point(223, 67);
            this.acessLevelAccount.Name = "acessLevelAccount";
            this.acessLevelAccount.Size = new System.Drawing.Size(100, 20);
            this.acessLevelAccount.TabIndex = 25;
            // 
            // goldText
            // 
            this.goldText.AutoSize = true;
            this.goldText.Location = new System.Drawing.Point(148, 51);
            this.goldText.Name = "goldText";
            this.goldText.Size = new System.Drawing.Size(29, 13);
            this.goldText.TabIndex = 24;
            this.goldText.Text = "Gold";
            // 
            // goldAccount
            // 
            this.goldAccount.Location = new System.Drawing.Point(118, 67);
            this.goldAccount.Name = "goldAccount";
            this.goldAccount.Size = new System.Drawing.Size(100, 20);
            this.goldAccount.TabIndex = 23;
            this.goldAccount.Text = "0";
            // 
            // emailText
            // 
            this.emailText.AutoSize = true;
            this.emailText.Location = new System.Drawing.Point(249, 10);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(35, 13);
            this.emailText.TabIndex = 22;
            this.emailText.Text = "E-mail";
            // 
            // emailAccount
            // 
            this.emailAccount.Location = new System.Drawing.Point(223, 27);
            this.emailAccount.Name = "emailAccount";
            this.emailAccount.Size = new System.Drawing.Size(100, 20);
            this.emailAccount.TabIndex = 21;
            // 
            // nickText
            // 
            this.nickText.AutoSize = true;
            this.nickText.Location = new System.Drawing.Point(139, 11);
            this.nickText.Name = "nickText";
            this.nickText.Size = new System.Drawing.Size(55, 13);
            this.nickText.TabIndex = 20;
            this.nickText.Text = "Nickname";
            // 
            // playerNameAccount
            // 
            this.playerNameAccount.Location = new System.Drawing.Point(118, 27);
            this.playerNameAccount.Name = "playerNameAccount";
            this.playerNameAccount.Size = new System.Drawing.Size(100, 20);
            this.playerNameAccount.TabIndex = 19;
            // 
            // carregarEdit
            // 
            this.carregarEdit.Location = new System.Drawing.Point(12, 203);
            this.carregarEdit.Name = "carregarEdit";
            this.carregarEdit.Size = new System.Drawing.Size(75, 23);
            this.carregarEdit.TabIndex = 27;
            this.carregarEdit.Text = "Carregar";
            this.carregarEdit.Click += new System.EventHandler(this.carregarEdit_Click);
            // 
            // moneyText
            // 
            this.moneyText.AutoSize = true;
            this.moneyText.Location = new System.Drawing.Point(44, 51);
            this.moneyText.Name = "moneyText";
            this.moneyText.Size = new System.Drawing.Size(31, 13);
            this.moneyText.TabIndex = 17;
            this.moneyText.Text = "Cash";
            // 
            // saveAccount
            // 
            this.saveAccount.Location = new System.Drawing.Point(102, 203);
            this.saveAccount.Name = "saveAccount";
            this.saveAccount.Size = new System.Drawing.Size(75, 23);
            this.saveAccount.TabIndex = 15;
            this.saveAccount.Text = "Salvar";
            this.saveAccount.UseVisualStyleBackColor = true;
            this.saveAccount.Visible = false;
            this.saveAccount.Click += new System.EventHandler(this.saveAccount_Click);
            // 
            // moneyAccount
            // 
            this.moneyAccount.Location = new System.Drawing.Point(12, 67);
            this.moneyAccount.Name = "moneyAccount";
            this.moneyAccount.Size = new System.Drawing.Size(100, 20);
            this.moneyAccount.TabIndex = 16;
            this.moneyAccount.Text = "0";
            // 
            // userText
            // 
            this.userText.AutoSize = true;
            this.userText.Location = new System.Drawing.Point(44, 11);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(33, 13);
            this.userText.TabIndex = 14;
            this.userText.Text = "Login";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(12, 27);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 20);
            this.user.TabIndex = 13;
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // hwidText
            // 
            this.hwidText.AutoSize = true;
            this.hwidText.Location = new System.Drawing.Point(62, 157);
            this.hwidText.Name = "hwidText";
            this.hwidText.Size = new System.Drawing.Size(37, 13);
            this.hwidText.TabIndex = 28;
            this.hwidText.Text = "HWID";
            // 
            // ipText
            // 
            this.ipText.AutoSize = true;
            this.ipText.Location = new System.Drawing.Point(220, 157);
            this.ipText.Name = "ipText";
            this.ipText.Size = new System.Drawing.Size(49, 13);
            this.ipText.TabIndex = 29;
            this.ipText.Text = "Último IP";
            // 
            // hwidBox
            // 
            this.hwidBox.Location = new System.Drawing.Point(12, 173);
            this.hwidBox.Name = "hwidBox";
            this.hwidBox.Size = new System.Drawing.Size(151, 20);
            this.hwidBox.TabIndex = 30;
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(169, 173);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(154, 20);
            this.ipBox.TabIndex = 31;
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 245);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.hwidBox);
            this.Controls.Add(this.ipText);
            this.Controls.Add(this.hwidText);
            this.Controls.Add(this.acessText);
            this.Controls.Add(this.acessLevelAccount);
            this.Controls.Add(this.goldText);
            this.Controls.Add(this.goldAccount);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.emailAccount);
            this.Controls.Add(this.nickText);
            this.Controls.Add(this.playerNameAccount);
            this.Controls.Add(this.carregarEdit);
            this.Controls.Add(this.moneyText);
            this.Controls.Add(this.saveAccount);
            this.Controls.Add(this.moneyAccount);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditAccount";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditAccount";
            this.Load += new System.EventHandler(this.EditAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label acessText;
        private System.Windows.Forms.TextBox acessLevelAccount;
        private System.Windows.Forms.Label goldText;
        private System.Windows.Forms.TextBox goldAccount;
        private System.Windows.Forms.Label emailText;
        private System.Windows.Forms.TextBox emailAccount;
        private System.Windows.Forms.Label nickText;
        private System.Windows.Forms.TextBox playerNameAccount;
        private System.Windows.Forms.Button carregarEdit;
        private System.Windows.Forms.Label moneyText;
        private System.Windows.Forms.Button saveAccount;
        private System.Windows.Forms.TextBox moneyAccount;
        private System.Windows.Forms.Label userText;
        private System.Windows.Forms.Label hwidText;
        private System.Windows.Forms.Label ipText;
        private System.Windows.Forms.TextBox hwidBox;
        private System.Windows.Forms.TextBox ipBox;
        public System.Windows.Forms.TextBox user;
    }
}