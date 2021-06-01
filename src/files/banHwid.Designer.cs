namespace ManageEdge
{
    partial class banHwid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(banHwid));
            this.hwidText = new System.Windows.Forms.Label();
            this.hwidBox = new System.Windows.Forms.TextBox();
            this.getHwidBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hwidText
            // 
            this.hwidText.AutoSize = true;
            this.hwidText.Location = new System.Drawing.Point(179, 18);
            this.hwidText.Name = "hwidText";
            this.hwidText.Size = new System.Drawing.Size(33, 13);
            this.hwidText.TabIndex = 0;
            this.hwidText.Text = "Login";
            // 
            // hwidBox
            // 
            this.hwidBox.Location = new System.Drawing.Point(12, 34);
            this.hwidBox.Name = "hwidBox";
            this.hwidBox.Size = new System.Drawing.Size(392, 20);
            this.hwidBox.TabIndex = 1;
            // 
            // getHwidBtn
            // 
            this.getHwidBtn.Location = new System.Drawing.Point(159, 60);
            this.getHwidBtn.Name = "getHwidBtn";
            this.getHwidBtn.Size = new System.Drawing.Size(75, 23);
            this.getHwidBtn.TabIndex = 2;
            this.getHwidBtn.Text = "Procurar";
            this.getHwidBtn.UseVisualStyleBackColor = true;
            this.getHwidBtn.Click += new System.EventHandler(this.banHwidBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Banir HWID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // banHwid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 97);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.getHwidBtn);
            this.Controls.Add(this.hwidBox);
            this.Controls.Add(this.hwidText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "banHwid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "banHWID";
            this.Load += new System.EventHandler(this.banHWID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hwidText;
        private System.Windows.Forms.TextBox hwidBox;
        private System.Windows.Forms.Button getHwidBtn;
        private System.Windows.Forms.Button button1;
    }
}