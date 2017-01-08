namespace MCO368_SemesterProj
{
    partial class AcountBalance
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
            this.label1 = new System.Windows.Forms.Label();
            this.BalanceAmount = new System.Windows.Forms.Label();
            this.pay_button = new System.Windows.Forms.Button();
            this.pay_Amount = new System.Windows.Forms.TextBox();
            this.pay_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // BalanceAmount
            // 
            this.BalanceAmount.AutoSize = true;
            this.BalanceAmount.Location = new System.Drawing.Point(155, 36);
            this.BalanceAmount.Name = "BalanceAmount";
            this.BalanceAmount.Size = new System.Drawing.Size(0, 17);
            this.BalanceAmount.TabIndex = 1;
            // 
            // pay_button
            // 
            this.pay_button.Location = new System.Drawing.Point(59, 172);
            this.pay_button.Name = "pay_button";
            this.pay_button.Size = new System.Drawing.Size(166, 55);
            this.pay_button.TabIndex = 2;
            this.pay_button.Text = "Submit Payment";
            this.pay_button.UseVisualStyleBackColor = true;
            this.pay_button.Click += new System.EventHandler(this.pay_button_Click);
            // 
            // pay_Amount
            // 
            this.pay_Amount.Location = new System.Drawing.Point(173, 121);
            this.pay_Amount.Name = "pay_Amount";
            this.pay_Amount.Size = new System.Drawing.Size(111, 22);
            this.pay_Amount.TabIndex = 3;
            // 
            // pay_Label
            // 
            this.pay_Label.AutoSize = true;
            this.pay_Label.Location = new System.Drawing.Point(15, 124);
            this.pay_Label.Name = "pay_Label";
            this.pay_Label.Size = new System.Drawing.Size(140, 17);
            this.pay_Label.TabIndex = 4;
            this.pay_Label.Text = "Enter amount to pay:";
            // 
            // AcountBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 280);
            this.Controls.Add(this.pay_Label);
            this.Controls.Add(this.pay_Amount);
            this.Controls.Add(this.pay_button);
            this.Controls.Add(this.BalanceAmount);
            this.Controls.Add(this.label1);
            this.Name = "AcountBalance";
            this.Text = "AcountBalance";
            this.Load += new System.EventHandler(this.AcountBalance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BalanceAmount;
        private System.Windows.Forms.Button pay_button;
        private System.Windows.Forms.TextBox pay_Amount;
        private System.Windows.Forms.Label pay_Label;
    }
}