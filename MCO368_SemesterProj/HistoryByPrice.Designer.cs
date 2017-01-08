namespace MCO368_SemesterProj
{
    partial class HistoryByPrice
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ByPrice_button = new System.Windows.Forms.Button();
            this.fromPrice = new System.Windows.Forms.Label();
            this.toPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 22);
            this.textBox2.TabIndex = 1;
            // 
            // ByPrice_button
            // 
            this.ByPrice_button.AutoSize = true;
            this.ByPrice_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByPrice_button.Location = new System.Drawing.Point(59, 78);
            this.ByPrice_button.Name = "ByPrice_button";
            this.ByPrice_button.Size = new System.Drawing.Size(147, 30);
            this.ByPrice_button.TabIndex = 2;
            this.ByPrice_button.Text = "View History";
            this.ByPrice_button.UseVisualStyleBackColor = true;
            this.ByPrice_button.Click += new System.EventHandler(this.ByPrice_button_Click);
            // 
            // fromPrice
            // 
            this.fromPrice.AutoSize = true;
            this.fromPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromPrice.Location = new System.Drawing.Point(28, 12);
            this.fromPrice.Name = "fromPrice";
            this.fromPrice.Size = new System.Drawing.Size(53, 20);
            this.fromPrice.TabIndex = 3;
            this.fromPrice.Text = "From:";
            // 
            // toPrice
            // 
            this.toPrice.AutoSize = true;
            this.toPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toPrice.Location = new System.Drawing.Point(154, 9);
            this.toPrice.Name = "toPrice";
            this.toPrice.Size = new System.Drawing.Size(33, 20);
            this.toPrice.TabIndex = 4;
            this.toPrice.Text = "To:";
            // 
            // HistoryByPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 120);
            this.Controls.Add(this.toPrice);
            this.Controls.Add(this.fromPrice);
            this.Controls.Add(this.ByPrice_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "HistoryByPrice";
            this.Text = "HistoryByPrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ByPrice_button;
        private System.Windows.Forms.Label fromPrice;
        private System.Windows.Forms.Label toPrice;
    }
}