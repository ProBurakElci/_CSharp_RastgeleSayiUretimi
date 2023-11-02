namespace _3_RastgeleSayiUretimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUret = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRandomSayi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(74, 147);
            this.btnUret.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(232, 37);
            this.btnUret.TabIndex = 0;
            this.btnUret.Text = "RASTGELE SAYI ÜRET";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Üretilen Sayı:";
            // 
            // lblRandomSayi
            // 
            this.lblRandomSayi.AutoSize = true;
            this.lblRandomSayi.Location = new System.Drawing.Point(208, 103);
            this.lblRandomSayi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRandomSayi.Name = "lblRandomSayi";
            this.lblRandomSayi.Size = new System.Drawing.Size(28, 16);
            this.lblRandomSayi.TabIndex = 2;
            this.lblRandomSayi.Text = "___";
            this.lblRandomSayi.Click += new System.EventHandler(this.lblRandomSayi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.lblRandomSayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUret);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRandomSayi;
    }
}

