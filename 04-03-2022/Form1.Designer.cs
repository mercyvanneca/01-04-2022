namespace _04_03_2022
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtBox_Bilangan1 = new System.Windows.Forms.TextBox();
            this.TxtBox_Bilangan2 = new System.Windows.Forms.TextBox();
            this.TxtBox_Hasil = new System.Windows.Forms.TextBox();
            this.Label_Bilangan1 = new System.Windows.Forms.Label();
            this.Label_Bilangan2 = new System.Windows.Forms.Label();
            this.Label_hasil = new System.Windows.Forms.Label();
            this.Button_Kali = new System.Windows.Forms.Button();
            this.Button_Bagi = new System.Windows.Forms.Button();
            this.Button_Tambah = new System.Windows.Forms.Button();
            this.Button_Kurang = new System.Windows.Forms.Button();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBox_Bilangan1
            // 
            this.TxtBox_Bilangan1.Location = new System.Drawing.Point(120, 27);
            this.TxtBox_Bilangan1.Name = "TxtBox_Bilangan1";
            this.TxtBox_Bilangan1.Size = new System.Drawing.Size(125, 23);
            this.TxtBox_Bilangan1.TabIndex = 0;
            this.TxtBox_Bilangan1.TextChanged += new System.EventHandler(this.TxtBox_Bilangan1_TextChanged);
            // 
            // TxtBox_Bilangan2
            // 
            this.TxtBox_Bilangan2.Location = new System.Drawing.Point(120, 56);
            this.TxtBox_Bilangan2.Name = "TxtBox_Bilangan2";
            this.TxtBox_Bilangan2.Size = new System.Drawing.Size(124, 23);
            this.TxtBox_Bilangan2.TabIndex = 1;
            // 
            // TxtBox_Hasil
            // 
            this.TxtBox_Hasil.Location = new System.Drawing.Point(120, 85);
            this.TxtBox_Hasil.Name = "TxtBox_Hasil";
            this.TxtBox_Hasil.Size = new System.Drawing.Size(124, 23);
            this.TxtBox_Hasil.TabIndex = 3;
            this.TxtBox_Hasil.TextChanged += new System.EventHandler(this.TxtBox_Hasil_TextChanged);
            // 
            // Label_Bilangan1
            // 
            this.Label_Bilangan1.AutoSize = true;
            this.Label_Bilangan1.Location = new System.Drawing.Point(12, 30);
            this.Label_Bilangan1.Name = "Label_Bilangan1";
            this.Label_Bilangan1.Size = new System.Drawing.Size(62, 15);
            this.Label_Bilangan1.TabIndex = 4;
            this.Label_Bilangan1.Text = "Bilangan 1";
            // 
            // Label_Bilangan2
            // 
            this.Label_Bilangan2.AutoSize = true;
            this.Label_Bilangan2.Location = new System.Drawing.Point(12, 59);
            this.Label_Bilangan2.Name = "Label_Bilangan2";
            this.Label_Bilangan2.Size = new System.Drawing.Size(62, 15);
            this.Label_Bilangan2.TabIndex = 5;
            this.Label_Bilangan2.Text = "Bilangan 2";
            // 
            // Label_hasil
            // 
            this.Label_hasil.AutoSize = true;
            this.Label_hasil.Location = new System.Drawing.Point(12, 88);
            this.Label_hasil.Name = "Label_hasil";
            this.Label_hasil.Size = new System.Drawing.Size(33, 15);
            this.Label_hasil.TabIndex = 6;
            this.Label_hasil.Text = "Hasil";
            // 
            // Button_Kali
            // 
            this.Button_Kali.Location = new System.Drawing.Point(12, 159);
            this.Button_Kali.Name = "Button_Kali";
            this.Button_Kali.Size = new System.Drawing.Size(62, 23);
            this.Button_Kali.TabIndex = 7;
            this.Button_Kali.Text = "X";
            this.Button_Kali.UseVisualStyleBackColor = true;
            this.Button_Kali.Click += new System.EventHandler(this.Button_Kali_Click);
            // 
            // Button_Bagi
            // 
            this.Button_Bagi.Location = new System.Drawing.Point(109, 159);
            this.Button_Bagi.Name = "Button_Bagi";
            this.Button_Bagi.Size = new System.Drawing.Size(62, 23);
            this.Button_Bagi.TabIndex = 8;
            this.Button_Bagi.Text = "%";
            this.Button_Bagi.UseVisualStyleBackColor = true;
            this.Button_Bagi.Click += new System.EventHandler(this.Button_Bagi_Click);
            // 
            // Button_Tambah
            // 
            this.Button_Tambah.Location = new System.Drawing.Point(200, 159);
            this.Button_Tambah.Name = "Button_Tambah";
            this.Button_Tambah.Size = new System.Drawing.Size(62, 23);
            this.Button_Tambah.TabIndex = 9;
            this.Button_Tambah.Text = "+";
            this.Button_Tambah.UseVisualStyleBackColor = true;
            this.Button_Tambah.Click += new System.EventHandler(this.Button_Tambah_Click);
            // 
            // Button_Kurang
            // 
            this.Button_Kurang.Location = new System.Drawing.Point(289, 159);
            this.Button_Kurang.Name = "Button_Kurang";
            this.Button_Kurang.Size = new System.Drawing.Size(62, 23);
            this.Button_Kurang.TabIndex = 10;
            this.Button_Kurang.Text = "-";
            this.Button_Kurang.UseVisualStyleBackColor = true;
            this.Button_Kurang.Click += new System.EventHandler(this.Button_Kurang_Click);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(200, 226);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(75, 23);
            this.Button_Clear.TabIndex = 11;
            this.Button_Clear.Text = "Clear";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Location = new System.Drawing.Point(96, 226);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(75, 23);
            this.Button_Exit.TabIndex = 12;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 261);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Button_Kurang);
            this.Controls.Add(this.Button_Tambah);
            this.Controls.Add(this.Button_Bagi);
            this.Controls.Add(this.Button_Kali);
            this.Controls.Add(this.Label_hasil);
            this.Controls.Add(this.Label_Bilangan2);
            this.Controls.Add(this.Label_Bilangan1);
            this.Controls.Add(this.TxtBox_Hasil);
            this.Controls.Add(this.TxtBox_Bilangan2);
            this.Controls.Add(this.TxtBox_Bilangan1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_Bilangan1;
        private System.Windows.Forms.TextBox TxtBox_Bilangan2;
        private System.Windows.Forms.TextBox TxtBox_Hasil;
        private System.Windows.Forms.Label Label_Bilangan1;
        private System.Windows.Forms.Label Label_Bilangan2;
        private System.Windows.Forms.Label Label_hasil;
        private System.Windows.Forms.Button Button_Kali;
        private System.Windows.Forms.Button Button_Bagi;
        private System.Windows.Forms.Button Button_Tambah;
        private System.Windows.Forms.Button Button_Kurang;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.Button Button_Exit;
    }
}
