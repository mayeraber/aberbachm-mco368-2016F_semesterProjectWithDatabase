namespace MCO368_SemesterProj
{
    partial class Form1
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
            this.userEntry = new System.Windows.Forms.RichTextBox();
            this.passwordEntry = new System.Windows.Forms.RichTextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LogIn = new System.Windows.Forms.Button();
            this.Balance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userEntry
            // 
            this.userEntry.Location = new System.Drawing.Point(110, 45);
            this.userEntry.Name = "userEntry";
            this.userEntry.Size = new System.Drawing.Size(138, 30);
            this.userEntry.TabIndex = 1;
            this.userEntry.Text = "";
            this.userEntry.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // passwordEntry
            // 
            this.passwordEntry.Location = new System.Drawing.Point(110, 98);
            this.passwordEntry.Multiline = false;
            this.passwordEntry.Name = "passwordEntry";
            this.passwordEntry.Size = new System.Drawing.Size(138, 33);
            this.passwordEntry.TabIndex = 2;
            this.passwordEntry.Text = "";
            this.passwordEntry.TextChanged += new System.EventHandler(this.passwordEntry_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Location = new System.Drawing.Point(25, 48);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(79, 27);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(25, 101);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(76, 22);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(136, 155);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(75, 30);
            this.LogIn.TabIndex = 5;
            this.LogIn.Text = "Log in";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Location = new System.Drawing.Point(45, 45);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(59, 17);
            this.Balance.TabIndex = 6;
            this.Balance.Text = "Balance";
            this.Balance.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 252);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.passwordEntry);
            this.Controls.Add(this.userEntry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox userEntry;
        private System.Windows.Forms.RichTextBox passwordEntry;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Label Balance;
    }
}

