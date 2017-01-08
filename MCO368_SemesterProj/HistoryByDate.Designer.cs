namespace MCO368_SemesterProj
{
    partial class HistoryByDate
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.From_Label = new System.Windows.Forms.Label();
            this.ByDate_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(8, 52);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // From_Label
            // 
            this.From_Label.AutoSize = true;
            this.From_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_Label.Location = new System.Drawing.Point(12, 23);
            this.From_Label.Name = "From_Label";
            this.From_Label.Size = new System.Drawing.Size(53, 20);
            this.From_Label.TabIndex = 2;
            this.From_Label.Text = "From:";
            // 
            // ByDate_button
            // 
            this.ByDate_button.AutoSize = true;
            this.ByDate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByDate_button.Location = new System.Drawing.Point(75, 282);
            this.ByDate_button.Name = "ByDate_button";
            this.ByDate_button.Size = new System.Drawing.Size(114, 30);
            this.ByDate_button.TabIndex = 4;
            this.ByDate_button.Text = "View History";
            this.ByDate_button.UseVisualStyleBackColor = true;
            this.ByDate_button.Click += new System.EventHandler(this.ByDate_button_Click);
            // 
            // HistoryByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(278, 496);
            this.Controls.Add(this.ByDate_button);
            this.Controls.Add(this.From_Label);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "HistoryByDate";
            this.Text = "HistoryByDate";
            this.Load += new System.EventHandler(this.HistoryByDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label From_Label;
        private System.Windows.Forms.Button ByDate_button;
    }
}