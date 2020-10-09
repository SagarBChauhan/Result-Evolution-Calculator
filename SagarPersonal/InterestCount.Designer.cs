namespace SagarPersonal
{
    partial class InterestCount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterestCount));
            this.LblAmt = new System.Windows.Forms.Label();
            this.LblInterestPercentage = new System.Windows.Forms.Label();
            this.LblDuratiion = new System.Windows.Forms.Label();
            this.TxtAmt = new System.Windows.Forms.TextBox();
            this.TxtIntPer = new System.Windows.Forms.TextBox();
            this.ComboMonth = new System.Windows.Forms.ComboBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblAmt
            // 
            this.LblAmt.AutoSize = true;
            this.LblAmt.BackColor = System.Drawing.Color.Transparent;
            this.LblAmt.Location = new System.Drawing.Point(38, 46);
            this.LblAmt.Name = "LblAmt";
            this.LblAmt.Size = new System.Drawing.Size(98, 17);
            this.LblAmt.TabIndex = 0;
            this.LblAmt.Text = "Enter Amount:";
            // 
            // LblInterestPercentage
            // 
            this.LblInterestPercentage.AutoSize = true;
            this.LblInterestPercentage.BackColor = System.Drawing.Color.Transparent;
            this.LblInterestPercentage.Location = new System.Drawing.Point(38, 80);
            this.LblInterestPercentage.Name = "LblInterestPercentage";
            this.LblInterestPercentage.Size = new System.Drawing.Size(136, 17);
            this.LblInterestPercentage.TabIndex = 1;
            this.LblInterestPercentage.Text = "Interest Percentage:";
            // 
            // LblDuratiion
            // 
            this.LblDuratiion.AutoSize = true;
            this.LblDuratiion.BackColor = System.Drawing.Color.Transparent;
            this.LblDuratiion.Location = new System.Drawing.Point(38, 112);
            this.LblDuratiion.Name = "LblDuratiion";
            this.LblDuratiion.Size = new System.Drawing.Size(66, 17);
            this.LblDuratiion.TabIndex = 2;
            this.LblDuratiion.Text = "Duration:";
            // 
            // TxtAmt
            // 
            this.TxtAmt.Location = new System.Drawing.Point(191, 41);
            this.TxtAmt.Name = "TxtAmt";
            this.TxtAmt.Size = new System.Drawing.Size(100, 22);
            this.TxtAmt.TabIndex = 3;
            // 
            // TxtIntPer
            // 
            this.TxtIntPer.Location = new System.Drawing.Point(191, 75);
            this.TxtIntPer.Name = "TxtIntPer";
            this.TxtIntPer.Size = new System.Drawing.Size(100, 22);
            this.TxtIntPer.TabIndex = 4;
            // 
            // ComboMonth
            // 
            this.ComboMonth.FormattingEnabled = true;
            this.ComboMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "12"});
            this.ComboMonth.Location = new System.Drawing.Point(246, 103);
            this.ComboMonth.Name = "ComboMonth";
            this.ComboMonth.Size = new System.Drawing.Size(45, 24);
            this.ComboMonth.TabIndex = 5;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalculate.Location = new System.Drawing.Point(121, 159);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 31);
            this.BtnCalculate.TabIndex = 7;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // TxtYear
            // 
            this.TxtYear.Location = new System.Drawing.Point(191, 103);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(49, 22);
            this.TxtYear.TabIndex = 8;
            this.TxtYear.Text = "0";
            // 
            // InterestCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SagarPersonal.Properties.Resources._5906319_background_wallpaper1;
            this.ClientSize = new System.Drawing.Size(343, 225);
            this.Controls.Add(this.TxtYear);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.ComboMonth);
            this.Controls.Add(this.TxtIntPer);
            this.Controls.Add(this.TxtAmt);
            this.Controls.Add(this.LblDuratiion);
            this.Controls.Add(this.LblInterestPercentage);
            this.Controls.Add(this.LblAmt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterestCount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interest Count";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAmt;
        private System.Windows.Forms.Label LblInterestPercentage;
        private System.Windows.Forms.Label LblDuratiion;
        private System.Windows.Forms.TextBox TxtAmt;
        private System.Windows.Forms.TextBox TxtIntPer;
        private System.Windows.Forms.ComboBox ComboMonth;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.TextBox TxtYear;
    }
}