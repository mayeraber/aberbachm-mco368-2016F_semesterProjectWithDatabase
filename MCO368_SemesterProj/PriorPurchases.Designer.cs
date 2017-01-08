namespace MCO368_SemesterProj
{
    partial class PriorPurchases
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
            this.All_Purchases = new System.Windows.Forms.Button();
            this.Date_Range = new System.Windows.Forms.Button();
            this.Price_Range = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // All_Purchases
            // 
            this.All_Purchases.AutoSize = true;
            this.All_Purchases.Location = new System.Drawing.Point(54, 12);
            this.All_Purchases.Name = "All_Purchases";
            this.All_Purchases.Size = new System.Drawing.Size(104, 27);
            this.All_Purchases.TabIndex = 0;
            this.All_Purchases.Text = "All Purchases";
            this.All_Purchases.UseVisualStyleBackColor = true;
            this.All_Purchases.Click += new System.EventHandler(this.button1_Click);
            // 
            // Date_Range
            // 
            this.Date_Range.AutoSize = true;
            this.Date_Range.Location = new System.Drawing.Point(41, 55);
            this.Date_Range.Name = "Date_Range";
            this.Date_Range.Size = new System.Drawing.Size(137, 27);
            this.Date_Range.TabIndex = 1;
            this.Date_Range.Text = "Within Date Range";
            this.Date_Range.UseVisualStyleBackColor = true;
            this.Date_Range.Click += new System.EventHandler(this.Date_Range_Click);
            // 
            // Price_Range
            // 
            this.Price_Range.AutoSize = true;
            this.Price_Range.Location = new System.Drawing.Point(26, 100);
            this.Price_Range.Name = "Price_Range";
            this.Price_Range.Size = new System.Drawing.Size(172, 27);
            this.Price_Range.TabIndex = 2;
            this.Price_Range.Text = "View Within Price Range";
            this.Price_Range.UseVisualStyleBackColor = true;
            this.Price_Range.Click += new System.EventHandler(this.Price_Range_Click);
            // 
            // PriorPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(221, 150);
            this.Controls.Add(this.Price_Range);
            this.Controls.Add(this.Date_Range);
            this.Controls.Add(this.All_Purchases);
            this.Name = "PriorPurchases";
            this.Text = "PriorPurchases";
            this.Load += new System.EventHandler(this.PriorPurchases_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button All_Purchases;
        private System.Windows.Forms.Button Date_Range;
        private System.Windows.Forms.Button Price_Range;
    }
}