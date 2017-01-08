namespace MCO368_SemesterProj
{
    partial class MainMenu
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
            this.catalog = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catalog
            // 
            this.catalog.AutoSize = true;
            this.catalog.Location = new System.Drawing.Point(49, 12);
            this.catalog.Name = "catalog";
            this.catalog.Size = new System.Drawing.Size(181, 59);
            this.catalog.TabIndex = 0;
            this.catalog.Text = "View and Purchase Items";
            this.catalog.UseVisualStyleBackColor = true;
            this.catalog.Click += new System.EventHandler(this.button1_Click);
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(49, 92);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(181, 57);
            this.balance.TabIndex = 1;
            this.balance.Text = "View and Pay Balance";
            this.balance.UseVisualStyleBackColor = true;
            this.balance.Click += new System.EventHandler(this.balance_Click);
            // 
            // history
            // 
            this.history.AutoSize = true;
            this.history.Location = new System.Drawing.Point(49, 168);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(181, 58);
            this.history.TabIndex = 2;
            this.history.Text = "View Prior Purchases";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.button3_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Location = new System.Drawing.Point(97, 245);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 27);
            this.exit.TabIndex = 3;
            this.exit.Text = "Sign Out";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 294);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.history);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.catalog);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button catalog;
        private System.Windows.Forms.Button balance;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Button exit;
    }
}