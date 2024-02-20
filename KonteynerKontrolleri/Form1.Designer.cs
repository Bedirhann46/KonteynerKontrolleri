namespace KonteynerKontrolleri
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbCpuİ7 = new System.Windows.Forms.RadioButton();
            this.rbCpui5 = new System.Windows.Forms.RadioButton();
            this.rbCpui3 = new System.Windows.Forms.RadioButton();
            this.rbCpuR5 = new System.Windows.Forms.RadioButton();
            this.rbCpuR3 = new System.Windows.Forms.RadioButton();
            this.rbRam16 = new System.Windows.Forms.RadioButton();
            this.rbRam8 = new System.Windows.Forms.RadioButton();
            this.rbRam4 = new System.Windows.Forms.RadioButton();
            this.rbHdd1000 = new System.Windows.Forms.RadioButton();
            this.rbHdd500 = new System.Windows.Forms.RadioButton();
            this.rbHdd320 = new System.Windows.Forms.RadioButton();
            this.cbDvd = new System.Windows.Forms.CheckBox();
            this.cbWebCam = new System.Windows.Forms.CheckBox();
            this.cbWifi = new System.Windows.Forms.CheckBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbCpuİ7
            // 
            this.rbCpuİ7.AutoSize = true;
            this.rbCpuİ7.Location = new System.Drawing.Point(46, 36);
            this.rbCpuİ7.Name = "rbCpuİ7";
            this.rbCpuİ7.Size = new System.Drawing.Size(79, 17);
            this.rbCpuİ7.TabIndex = 0;
            this.rbCpuİ7.TabStop = true;
            this.rbCpuİ7.Text = "intel core i7";
            this.rbCpuİ7.UseVisualStyleBackColor = true;
            // 
            // rbCpui5
            // 
            this.rbCpui5.AutoSize = true;
            this.rbCpui5.Location = new System.Drawing.Point(46, 60);
            this.rbCpui5.Name = "rbCpui5";
            this.rbCpui5.Size = new System.Drawing.Size(79, 17);
            this.rbCpui5.TabIndex = 1;
            this.rbCpui5.TabStop = true;
            this.rbCpui5.Text = "intel core i5";
            this.rbCpui5.UseVisualStyleBackColor = true;
            // 
            // rbCpui3
            // 
            this.rbCpui3.AutoSize = true;
            this.rbCpui3.Location = new System.Drawing.Point(46, 84);
            this.rbCpui3.Name = "rbCpui3";
            this.rbCpui3.Size = new System.Drawing.Size(79, 17);
            this.rbCpui3.TabIndex = 2;
            this.rbCpui3.TabStop = true;
            this.rbCpui3.Text = "intel core i3";
            this.rbCpui3.UseVisualStyleBackColor = true;
            // 
            // rbCpuR5
            // 
            this.rbCpuR5.AutoSize = true;
            this.rbCpuR5.Location = new System.Drawing.Point(46, 108);
            this.rbCpuR5.Name = "rbCpuR5";
            this.rbCpuR5.Size = new System.Drawing.Size(91, 17);
            this.rbCpuR5.TabIndex = 3;
            this.rbCpuR5.TabStop = true;
            this.rbCpuR5.Text = "AMD Ryzen 5";
            this.rbCpuR5.UseVisualStyleBackColor = true;
            // 
            // rbCpuR3
            // 
            this.rbCpuR3.AutoSize = true;
            this.rbCpuR3.Location = new System.Drawing.Point(46, 132);
            this.rbCpuR3.Name = "rbCpuR3";
            this.rbCpuR3.Size = new System.Drawing.Size(91, 17);
            this.rbCpuR3.TabIndex = 4;
            this.rbCpuR3.TabStop = true;
            this.rbCpuR3.Text = "AMD Ryzen 3";
            this.rbCpuR3.UseVisualStyleBackColor = true;
            // 
            // rbRam16
            // 
            this.rbRam16.AutoSize = true;
            this.rbRam16.Location = new System.Drawing.Point(51, 50);
            this.rbRam16.Name = "rbRam16";
            this.rbRam16.Size = new System.Drawing.Size(52, 17);
            this.rbRam16.TabIndex = 5;
            this.rbRam16.TabStop = true;
            this.rbRam16.Text = "16GB";
            this.rbRam16.UseVisualStyleBackColor = true;
            // 
            // rbRam8
            // 
            this.rbRam8.AutoSize = true;
            this.rbRam8.Location = new System.Drawing.Point(51, 83);
            this.rbRam8.Name = "rbRam8";
            this.rbRam8.Size = new System.Drawing.Size(46, 17);
            this.rbRam8.TabIndex = 6;
            this.rbRam8.TabStop = true;
            this.rbRam8.Text = "8GB";
            this.rbRam8.UseVisualStyleBackColor = true;
            // 
            // rbRam4
            // 
            this.rbRam4.AutoSize = true;
            this.rbRam4.Location = new System.Drawing.Point(51, 122);
            this.rbRam4.Name = "rbRam4";
            this.rbRam4.Size = new System.Drawing.Size(46, 17);
            this.rbRam4.TabIndex = 7;
            this.rbRam4.TabStop = true;
            this.rbRam4.Text = "4GB";
            this.rbRam4.UseVisualStyleBackColor = true;
            // 
            // rbHdd1000
            // 
            this.rbHdd1000.AutoSize = true;
            this.rbHdd1000.Location = new System.Drawing.Point(52, 43);
            this.rbHdd1000.Name = "rbHdd1000";
            this.rbHdd1000.Size = new System.Drawing.Size(50, 17);
            this.rbHdd1000.TabIndex = 8;
            this.rbHdd1000.TabStop = true;
            this.rbHdd1000.Text = "birTB";
            this.rbHdd1000.UseVisualStyleBackColor = true;
            // 
            // rbHdd500
            // 
            this.rbHdd500.AutoSize = true;
            this.rbHdd500.Location = new System.Drawing.Point(52, 76);
            this.rbHdd500.Name = "rbHdd500";
            this.rbHdd500.Size = new System.Drawing.Size(58, 17);
            this.rbHdd500.TabIndex = 9;
            this.rbHdd500.TabStop = true;
            this.rbHdd500.Text = "500GB";
            this.rbHdd500.UseVisualStyleBackColor = true;
            // 
            // rbHdd320
            // 
            this.rbHdd320.AutoSize = true;
            this.rbHdd320.Location = new System.Drawing.Point(52, 115);
            this.rbHdd320.Name = "rbHdd320";
            this.rbHdd320.Size = new System.Drawing.Size(58, 17);
            this.rbHdd320.TabIndex = 10;
            this.rbHdd320.TabStop = true;
            this.rbHdd320.Text = "320GB";
            this.rbHdd320.UseVisualStyleBackColor = true;
            // 
            // cbDvd
            // 
            this.cbDvd.AutoSize = true;
            this.cbDvd.Location = new System.Drawing.Point(27, 36);
            this.cbDvd.Name = "cbDvd";
            this.cbDvd.Size = new System.Drawing.Size(71, 17);
            this.cbDvd.TabIndex = 11;
            this.cbDvd.Text = "DVD RW";
            this.cbDvd.UseVisualStyleBackColor = true;
            // 
            // cbWebCam
            // 
            this.cbWebCam.AutoSize = true;
            this.cbWebCam.Location = new System.Drawing.Point(27, 71);
            this.cbWebCam.Name = "cbWebCam";
            this.cbWebCam.Size = new System.Drawing.Size(73, 17);
            this.cbWebCam.TabIndex = 12;
            this.cbWebCam.Text = "Web Cam";
            this.cbWebCam.UseVisualStyleBackColor = true;
            // 
            // cbWifi
            // 
            this.cbWifi.AutoSize = true;
            this.cbWifi.Location = new System.Drawing.Point(27, 109);
            this.cbWifi.Name = "cbWifi";
            this.cbWifi.Size = new System.Drawing.Size(87, 17);
            this.cbWifi.TabIndex = 13;
            this.cbWifi.Text = "Wireless kart";
            this.cbWifi.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(334, 233);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(261, 124);
            this.btnHesapla.TabIndex = 14;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDvd);
            this.groupBox1.Controls.Add(this.cbWebCam);
            this.groupBox1.Controls.Add(this.cbWifi);
            this.groupBox1.Location = new System.Drawing.Point(46, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 214);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ek Donanımlar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbCpuİ7);
            this.groupBox2.Controls.Add(this.rbCpui5);
            this.groupBox2.Controls.Add(this.rbCpui3);
            this.groupBox2.Controls.Add(this.rbCpuR5);
            this.groupBox2.Controls.Add(this.rbCpuR3);
            this.groupBox2.Location = new System.Drawing.Point(35, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 160);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemciler";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbRam16);
            this.groupBox3.Controls.Add(this.rbRam8);
            this.groupBox3.Controls.Add(this.rbRam4);
            this.groupBox3.Location = new System.Drawing.Point(266, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 146);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ram Bellek";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbHdd1000);
            this.groupBox4.Controls.Add(this.rbHdd500);
            this.groupBox4.Controls.Add(this.rbHdd320);
            this.groupBox4.Location = new System.Drawing.Point(420, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(154, 159);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sabit Disk";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "broupbox kontrolleri uygulama 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCpuİ7;
        private System.Windows.Forms.RadioButton rbCpui5;
        private System.Windows.Forms.RadioButton rbCpui3;
        private System.Windows.Forms.RadioButton rbCpuR5;
        private System.Windows.Forms.RadioButton rbCpuR3;
        private System.Windows.Forms.RadioButton rbRam16;
        private System.Windows.Forms.RadioButton rbRam8;
        private System.Windows.Forms.RadioButton rbRam4;
        private System.Windows.Forms.RadioButton rbHdd1000;
        private System.Windows.Forms.RadioButton rbHdd500;
        private System.Windows.Forms.RadioButton rbHdd320;
        private System.Windows.Forms.CheckBox cbDvd;
        private System.Windows.Forms.CheckBox cbWebCam;
        private System.Windows.Forms.CheckBox cbWifi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

