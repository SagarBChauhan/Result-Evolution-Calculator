namespace SagarPersonal
{
    partial class Evolution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evolution));
            this.TxtSem1 = new System.Windows.Forms.TextBox();
            this.TxtSem2 = new System.Windows.Forms.TextBox();
            this.TxtSem3 = new System.Windows.Forms.TextBox();
            this.TxtSem4 = new System.Windows.Forms.TextBox();
            this.TxtSem5 = new System.Windows.Forms.TextBox();
            this.TxtSem6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtSem1
            // 
            this.TxtSem1.Location = new System.Drawing.Point(51, 46);
            this.TxtSem1.Name = "TxtSem1";
            this.TxtSem1.Size = new System.Drawing.Size(95, 22);
            this.TxtSem1.TabIndex = 0;
            this.TxtSem1.TabIndexChanged += new System.EventHandler(this.TxtSem6_TabIndexChanged);
            this.TxtSem1.TextChanged += new System.EventHandler(this.TxtSem1_TextChanged);
            // 
            // TxtSem2
            // 
            this.TxtSem2.Location = new System.Drawing.Point(166, 46);
            this.TxtSem2.Name = "TxtSem2";
            this.TxtSem2.Size = new System.Drawing.Size(95, 22);
            this.TxtSem2.TabIndex = 1;
            this.TxtSem2.TabIndexChanged += new System.EventHandler(this.TxtSem6_TabIndexChanged);
            this.TxtSem2.TextChanged += new System.EventHandler(this.TxtSem1_TextChanged);
            // 
            // TxtSem3
            // 
            this.TxtSem3.Location = new System.Drawing.Point(51, 91);
            this.TxtSem3.Name = "TxtSem3";
            this.TxtSem3.Size = new System.Drawing.Size(95, 22);
            this.TxtSem3.TabIndex = 2;
            this.TxtSem3.TabIndexChanged += new System.EventHandler(this.TxtSem6_TabIndexChanged);
            this.TxtSem3.TextChanged += new System.EventHandler(this.TxtSem1_TextChanged);
            // 
            // TxtSem4
            // 
            this.TxtSem4.Location = new System.Drawing.Point(166, 91);
            this.TxtSem4.Name = "TxtSem4";
            this.TxtSem4.Size = new System.Drawing.Size(95, 22);
            this.TxtSem4.TabIndex = 3;
            this.TxtSem4.TabIndexChanged += new System.EventHandler(this.TxtSem6_TabIndexChanged);
            this.TxtSem4.TextChanged += new System.EventHandler(this.TxtSem1_TextChanged);
            // 
            // TxtSem5
            // 
            this.TxtSem5.Location = new System.Drawing.Point(51, 130);
            this.TxtSem5.Name = "TxtSem5";
            this.TxtSem5.Size = new System.Drawing.Size(95, 22);
            this.TxtSem5.TabIndex = 4;
            this.TxtSem5.TabIndexChanged += new System.EventHandler(this.TxtSem6_TabIndexChanged);
            this.TxtSem5.TextChanged += new System.EventHandler(this.TxtSem1_TextChanged);
            // 
            // TxtSem6
            // 
            this.TxtSem6.Location = new System.Drawing.Point(166, 130);
            this.TxtSem6.Name = "TxtSem6";
            this.TxtSem6.Size = new System.Drawing.Size(95, 22);
            this.TxtSem6.TabIndex = 5;
            this.TxtSem6.TabIndexChanged += new System.EventHandler(this.TxtSem6_TabIndexChanged);
            this.TxtSem6.TextChanged += new System.EventHandler(this.TxtSem1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Result:";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.BackColor = System.Drawing.Color.Transparent;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(106, 191);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 17);
            this.Result.TabIndex = 7;
            // 
            // Evolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SagarPersonal.Properties.Resources._5906319_background_wallpaper1;
            this.ClientSize = new System.Drawing.Size(316, 275);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSem6);
            this.Controls.Add(this.TxtSem5);
            this.Controls.Add(this.TxtSem4);
            this.Controls.Add(this.TxtSem3);
            this.Controls.Add(this.TxtSem2);
            this.Controls.Add(this.TxtSem1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Evolution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evolution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSem1;
        private System.Windows.Forms.TextBox TxtSem2;
        private System.Windows.Forms.TextBox TxtSem3;
        private System.Windows.Forms.TextBox TxtSem4;
        private System.Windows.Forms.TextBox TxtSem5;
        private System.Windows.Forms.TextBox TxtSem6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Result;
    }
}