namespace DiziUyg2
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
            this.adet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yuksekDeger = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dusukDeger = new System.Windows.Forms.TextBox();
            this.istenenSayi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sonuc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // adet
            // 
            this.adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.adet.Location = new System.Drawing.Point(252, 33);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(100, 35);
            this.adet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kaç adet sayı olsun";
            // 
            // yuksekDeger
            // 
            this.yuksekDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.yuksekDeger.Location = new System.Drawing.Point(322, 71);
            this.yuksekDeger.Name = "yuksekDeger";
            this.yuksekDeger.Size = new System.Drawing.Size(100, 35);
            this.yuksekDeger.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(-1, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "En yüksek deger kaç olsun";
            // 
            // dusukDeger
            // 
            this.dusukDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.dusukDeger.Location = new System.Drawing.Point(322, 112);
            this.dusukDeger.Name = "dusukDeger";
            this.dusukDeger.Size = new System.Drawing.Size(100, 35);
            this.dusukDeger.TabIndex = 0;
            // 
            // istenenSayi
            // 
            this.istenenSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.istenenSayi.Location = new System.Drawing.Point(429, 156);
            this.istenenSayi.Name = "istenenSayi";
            this.istenenSayi.Size = new System.Drawing.Size(100, 35);
            this.istenenSayi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(-1, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "En düşük deger kaç olsun";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label4.Location = new System.Drawing.Point(-1, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(424, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dizide hangi sayıyı aramak istersiniz";
            // 
            // sonuc
            // 
            this.sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.sonuc.Location = new System.Drawing.Point(66, 282);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(262, 20);
            this.sonuc.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "BUL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(554, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(174, 268);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.istenenSayi);
            this.Controls.Add(this.dusukDeger);
            this.Controls.Add(this.yuksekDeger);
            this.Controls.Add(this.adet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yuksekDeger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dusukDeger;
        private System.Windows.Forms.TextBox istenenSayi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

