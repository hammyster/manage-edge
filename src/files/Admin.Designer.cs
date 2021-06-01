namespace ManageEdge
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.button3 = new System.Windows.Forms.Button();
            this.connpg = new System.Windows.Forms.Button();
            this.tabConnection = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.resetAccessLauncher = new System.Windows.Forms.Button();
            this.changePassBtn = new System.Windows.Forms.Button();
            this.getAccountIPBtn = new System.Windows.Forms.Button();
            this.editAccountBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.connectionBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.portCntBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dbCntBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passCntBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userCntBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hostCntBox = new System.Windows.Forms.TextBox();
            this.banHWID = new System.Windows.Forms.Button();
            this.resetTempBtn = new System.Windows.Forms.Button();
            this.tabConnection.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // connpg
            // 
            this.connpg.Location = new System.Drawing.Point(0, 0);
            this.connpg.Name = "connpg";
            this.connpg.Size = new System.Drawing.Size(75, 23);
            this.connpg.TabIndex = 0;
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.tabPage1);
            this.tabConnection.Controls.Add(this.tabPage2);
            this.tabConnection.Location = new System.Drawing.Point(11, 4);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.SelectedIndex = 0;
            this.tabConnection.Size = new System.Drawing.Size(333, 283);
            this.tabConnection.TabIndex = 0;
            this.tabConnection.Text = "Conexão";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.resetTempBtn);
            this.tabPage1.Controls.Add(this.banHWID);
            this.tabPage1.Controls.Add(this.resetAccessLauncher);
            this.tabPage1.Controls.Add(this.changePassBtn);
            this.tabPage1.Controls.Add(this.getAccountIPBtn);
            this.tabPage1.Controls.Add(this.editAccountBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(325, 257);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gerenciamento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // resetAccessLauncher
            // 
            this.resetAccessLauncher.Location = new System.Drawing.Point(6, 52);
            this.resetAccessLauncher.Name = "resetAccessLauncher";
            this.resetAccessLauncher.Size = new System.Drawing.Size(100, 40);
            this.resetAccessLauncher.TabIndex = 4;
            this.resetAccessLauncher.Text = "Resetar Access Launcher";
            this.resetAccessLauncher.UseVisualStyleBackColor = true;
            this.resetAccessLauncher.Click += new System.EventHandler(this.button1_Click);
            // 
            // changePassBtn
            // 
            this.changePassBtn.Location = new System.Drawing.Point(218, 6);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(100, 40);
            this.changePassBtn.TabIndex = 3;
            this.changePassBtn.Text = "Alterar senha por Login";
            this.changePassBtn.UseVisualStyleBackColor = true;
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // getAccountIPBtn
            // 
            this.getAccountIPBtn.Location = new System.Drawing.Point(112, 6);
            this.getAccountIPBtn.Name = "getAccountIPBtn";
            this.getAccountIPBtn.Size = new System.Drawing.Size(100, 40);
            this.getAccountIPBtn.TabIndex = 2;
            this.getAccountIPBtn.Text = "Procurar conta por IP";
            this.getAccountIPBtn.UseVisualStyleBackColor = true;
            this.getAccountIPBtn.Click += new System.EventHandler(this.getAccountIPBtn_Click);
            // 
            // editAccountBtn
            // 
            this.editAccountBtn.Location = new System.Drawing.Point(6, 6);
            this.editAccountBtn.Name = "editAccountBtn";
            this.editAccountBtn.Size = new System.Drawing.Size(100, 40);
            this.editAccountBtn.TabIndex = 1;
            this.editAccountBtn.Text = "Editar conta";
            this.editAccountBtn.UseVisualStyleBackColor = true;
            this.editAccountBtn.Click += new System.EventHandler(this.editAccountBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.connectionBtn);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.portCntBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dbCntBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.passCntBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.userCntBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.hostCntBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(325, 257);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conexão";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // connectionBtn
            // 
            this.connectionBtn.Location = new System.Drawing.Point(107, 209);
            this.connectionBtn.Name = "connectionBtn";
            this.connectionBtn.Size = new System.Drawing.Size(105, 23);
            this.connectionBtn.TabIndex = 10;
            this.connectionBtn.Text = "Testar conexão";
            this.connectionBtn.UseVisualStyleBackColor = true;
            this.connectionBtn.Click += new System.EventHandler(this.connectionBtn_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 156);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PORT";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // portCntBox
            // 
            this.portCntBox.Location = new System.Drawing.Point(170, 172);
            this.portCntBox.Name = "portCntBox";
            this.portCntBox.Size = new System.Drawing.Size(149, 20);
            this.portCntBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 156);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DATABASE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbCntBox
            // 
            this.dbCntBox.Location = new System.Drawing.Point(6, 172);
            this.dbCntBox.Name = "dbCntBox";
            this.dbCntBox.Size = new System.Drawing.Size(149, 20);
            this.dbCntBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 111);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "PASS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passCntBox
            // 
            this.passCntBox.Location = new System.Drawing.Point(4, 127);
            this.passCntBox.Name = "passCntBox";
            this.passCntBox.Size = new System.Drawing.Size(317, 20);
            this.passCntBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "USER";
            // 
            // userCntBox
            // 
            this.userCntBox.Location = new System.Drawing.Point(4, 79);
            this.userCntBox.Name = "userCntBox";
            this.userCntBox.Size = new System.Drawing.Size(317, 20);
            this.userCntBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOST";
            // 
            // hostCntBox
            // 
            this.hostCntBox.Location = new System.Drawing.Point(4, 32);
            this.hostCntBox.Name = "hostCntBox";
            this.hostCntBox.Size = new System.Drawing.Size(317, 20);
            this.hostCntBox.TabIndex = 0;
            this.hostCntBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // banHWID
            // 
            this.banHWID.Location = new System.Drawing.Point(218, 52);
            this.banHWID.Name = "banHWID";
            this.banHWID.Size = new System.Drawing.Size(100, 40);
            this.banHWID.TabIndex = 5;
            this.banHWID.Text = "Banir HWID";
            this.banHWID.UseVisualStyleBackColor = true;
            this.banHWID.Click += new System.EventHandler(this.banHWID_Click);
            // 
            // resetTempBtn
            // 
            this.resetTempBtn.Location = new System.Drawing.Point(112, 52);
            this.resetTempBtn.Name = "resetTempBtn";
            this.resetTempBtn.Size = new System.Drawing.Size(100, 40);
            this.resetTempBtn.TabIndex = 6;
            this.resetTempBtn.Text = "Resetar Temporada";
            this.resetTempBtn.UseVisualStyleBackColor = true;
            this.resetTempBtn.Click += new System.EventHandler(this.resetTempBtn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 299);
            this.Controls.Add(this.tabConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabConnection.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button connpg;
        private System.Windows.Forms.TabControl tabConnection;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button editAccountBtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox hostCntBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userCntBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passCntBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox portCntBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dbCntBox;
        private System.Windows.Forms.Button connectionBtn;
        private System.Windows.Forms.Button changePassBtn;
        private System.Windows.Forms.Button getAccountIPBtn;
        private System.Windows.Forms.Button resetAccessLauncher;
        private System.Windows.Forms.Button banHWID;
        private System.Windows.Forms.Button resetTempBtn;
    }
}

