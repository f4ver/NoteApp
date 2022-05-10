namespace NoteApp.View
{
    partial class AboutForm
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
            this.nameAppLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.nameAuthorLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.githubLabel = new System.Windows.Forms.Label();
            this.emailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.githubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameAppLabel
            // 
            this.nameAppLabel.AutoSize = true;
            this.nameAppLabel.Font = new System.Drawing.Font("Meiryo", 13F, System.Drawing.FontStyle.Bold);
            this.nameAppLabel.Location = new System.Drawing.Point(9, 9);
            this.nameAppLabel.Name = "nameAppLabel";
            this.nameAppLabel.Size = new System.Drawing.Size(95, 27);
            this.nameAppLabel.TabIndex = 0;
            this.nameAppLabel.Text = "NoteApp";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(16, 36);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(43, 13);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "v. 1.0.0";
            this.versionLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // nameAuthorLabel
            // 
            this.nameAuthorLabel.AutoSize = true;
            this.nameAuthorLabel.Location = new System.Drawing.Point(15, 83);
            this.nameAuthorLabel.Name = "nameAuthorLabel";
            this.nameAuthorLabel.Size = new System.Drawing.Size(105, 13);
            this.nameAuthorLabel.TabIndex = 2;
            this.nameAuthorLabel.Text = "Author: Oleg Filippov";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(17, 139);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(100, 13);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "e-mail for feedback:";
            this.emailLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // githubLabel
            // 
            this.githubLabel.AutoSize = true;
            this.githubLabel.Location = new System.Drawing.Point(17, 154);
            this.githubLabel.Name = "githubLabel";
            this.githubLabel.Size = new System.Drawing.Size(41, 13);
            this.githubLabel.TabIndex = 4;
            this.githubLabel.Text = "Github:";
            this.githubLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // emailLinkLabel
            // 
            this.emailLinkLabel.AutoSize = true;
            this.emailLinkLabel.Location = new System.Drawing.Point(123, 139);
            this.emailLinkLabel.Name = "emailLinkLabel";
            this.emailLinkLabel.Size = new System.Drawing.Size(102, 13);
            this.emailLinkLabel.TabIndex = 5;
            this.emailLinkLabel.TabStop = true;
            this.emailLinkLabel.Text = "o.filipow@yandex.ru";
            // 
            // githubLinkLabel
            // 
            this.githubLinkLabel.AutoSize = true;
            this.githubLinkLabel.Location = new System.Drawing.Point(64, 154);
            this.githubLinkLabel.Name = "githubLinkLabel";
            this.githubLinkLabel.Size = new System.Drawing.Size(124, 13);
            this.githubLinkLabel.TabIndex = 6;
            this.githubLinkLabel.TabStop = true;
            this.githubLinkLabel.Text = "https://github.com/f4ver";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(11, 284);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(107, 13);
            this.copyrightLabel.TabIndex = 7;
            this.copyrightLabel.Text = "2022 Oleg Filippov ©";
            this.copyrightLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 306);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.githubLinkLabel);
            this.Controls.Add(this.emailLinkLabel);
            this.Controls.Add(this.githubLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameAuthorLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.nameAppLabel);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameAppLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label nameAuthorLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label githubLabel;
        private System.Windows.Forms.LinkLabel emailLinkLabel;
        private System.Windows.Forms.LinkLabel githubLinkLabel;
        private System.Windows.Forms.Label copyrightLabel;
    }
}