namespace ManageEdge
{
    partial class changePassLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changePassLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.hashBox = new System.Windows.Forms.TextBox();
            this.hashText = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(12, 34);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(433, 20);
            this.loginBox.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(178, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Procurar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(12, 34);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(433, 20);
            this.passBox.TabIndex = 3;
            // 
            // hashBox
            // 
            this.hashBox.Location = new System.Drawing.Point(12, 78);
            this.hashBox.Name = "hashBox";
            this.hashBox.Size = new System.Drawing.Size(433, 20);
            this.hashBox.TabIndex = 6;
            // 
            // hashText
            // 
            this.hashText.AutoSize = true;
            this.hashText.Location = new System.Drawing.Point(197, 62);
            this.hashText.Name = "hashText";
            this.hashText.Size = new System.Drawing.Size(37, 13);
            this.hashText.TabIndex = 5;
            this.hashText.Text = "HASH";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(178, 105);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Salvar";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // changePassLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 163);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.hashBox);
            this.Controls.Add(this.hashText);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "changePassLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "changePassLogin";
            this.Load += new System.EventHandler(this.changePassLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox hashBox;
        private System.Windows.Forms.Label hashText;
        private System.Windows.Forms.Button saveBtn;
    }
}