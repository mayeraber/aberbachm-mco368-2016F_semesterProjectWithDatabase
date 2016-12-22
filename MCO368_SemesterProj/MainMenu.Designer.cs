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
            this.button1 = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(49, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "View and Purchase Items";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(49, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "View Prior Purchases";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.button1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button balance;
        private System.Windows.Forms.Button button3;
    }
}