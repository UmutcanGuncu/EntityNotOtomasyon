namespace EntityNotOtomasyon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonOgrListe = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonBul = new System.Windows.Forms.Button();
            this.buttonDersListele = new System.Windows.Forms.Button();
            this.buttonNotListele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxOgrFotograf = new System.Windows.Forms.TextBox();
            this.textBoxOgrSoyad = new System.Windows.Forms.TextBox();
            this.textBoxOgrAd = new System.Windows.Forms.TextBox();
            this.textBoxOgrId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDersEkle = new System.Windows.Forms.Button();
            this.textBoxDersAd = new System.Windows.Forms.TextBox();
            this.textBoxDersId = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxOrtalama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDurum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSinav3 = new System.Windows.Forms.TextBox();
            this.textBoxSinav1 = new System.Windows.Forms.TextBox();
            this.textBoxSinav2 = new System.Windows.Forms.TextBox();
            this.buttonNotGuncelle = new System.Windows.Forms.Button();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(972, 193);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // buttonOgrListe
            // 
            this.buttonOgrListe.Location = new System.Drawing.Point(12, 243);
            this.buttonOgrListe.Name = "buttonOgrListe";
            this.buttonOgrListe.Size = new System.Drawing.Size(207, 52);
            this.buttonOgrListe.TabIndex = 1;
            this.buttonOgrListe.Text = "Öğrenci Listele";
            this.buttonOgrListe.UseVisualStyleBackColor = true;
            this.buttonOgrListe.Click += new System.EventHandler(this.buttonOgrListe_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(12, 301);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(207, 52);
            this.buttonKaydet.TabIndex = 2;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(12, 359);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(207, 52);
            this.buttonSil.TabIndex = 3;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(12, 417);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(207, 52);
            this.buttonGuncelle.TabIndex = 4;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonBul
            // 
            this.buttonBul.Location = new System.Drawing.Point(12, 475);
            this.buttonBul.Name = "buttonBul";
            this.buttonBul.Size = new System.Drawing.Size(207, 52);
            this.buttonBul.TabIndex = 5;
            this.buttonBul.Text = "Bul";
            this.buttonBul.UseVisualStyleBackColor = true;
            this.buttonBul.Click += new System.EventHandler(this.buttonBul_Click);
            // 
            // buttonDersListele
            // 
            this.buttonDersListele.Location = new System.Drawing.Point(12, 533);
            this.buttonDersListele.Name = "buttonDersListele";
            this.buttonDersListele.Size = new System.Drawing.Size(207, 52);
            this.buttonDersListele.TabIndex = 6;
            this.buttonDersListele.Text = "Ders Listesi";
            this.buttonDersListele.UseVisualStyleBackColor = true;
            this.buttonDersListele.Click += new System.EventHandler(this.buttonDersListele_Click);
            // 
            // buttonNotListele
            // 
            this.buttonNotListele.Location = new System.Drawing.Point(12, 591);
            this.buttonNotListele.Name = "buttonNotListele";
            this.buttonNotListele.Size = new System.Drawing.Size(207, 52);
            this.buttonNotListele.TabIndex = 7;
            this.buttonNotListele.Text = "Not Listesi";
            this.buttonNotListele.UseVisualStyleBackColor = true;
            this.buttonNotListele.Click += new System.EventHandler(this.buttonNotListele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxOgrFotograf);
            this.groupBox1.Controls.Add(this.textBoxOgrSoyad);
            this.groupBox1.Controls.Add(this.textBoxOgrAd);
            this.groupBox1.Controls.Add(this.textBoxOgrId);
            this.groupBox1.Location = new System.Drawing.Point(268, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 216);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fotoğraf:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(103, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 28);
            this.label11.TabIndex = 1;
            this.label11.Text = "Ad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 28);
            this.label10.TabIndex = 1;
            this.label10.Text = "Id:";
            // 
            // textBoxOgrFotograf
            // 
            this.textBoxOgrFotograf.Location = new System.Drawing.Point(152, 161);
            this.textBoxOgrFotograf.Name = "textBoxOgrFotograf";
            this.textBoxOgrFotograf.Size = new System.Drawing.Size(197, 36);
            this.textBoxOgrFotograf.TabIndex = 11;
            // 
            // textBoxOgrSoyad
            // 
            this.textBoxOgrSoyad.Location = new System.Drawing.Point(152, 119);
            this.textBoxOgrSoyad.Name = "textBoxOgrSoyad";
            this.textBoxOgrSoyad.Size = new System.Drawing.Size(197, 36);
            this.textBoxOgrSoyad.TabIndex = 10;
            // 
            // textBoxOgrAd
            // 
            this.textBoxOgrAd.Location = new System.Drawing.Point(152, 77);
            this.textBoxOgrAd.Name = "textBoxOgrAd";
            this.textBoxOgrAd.Size = new System.Drawing.Size(197, 36);
            this.textBoxOgrAd.TabIndex = 9;
            this.textBoxOgrAd.TextChanged += new System.EventHandler(this.textBoxOgrAd_TextChanged);
            // 
            // textBoxOgrId
            // 
            this.textBoxOgrId.Location = new System.Drawing.Point(152, 35);
            this.textBoxOgrId.Name = "textBoxOgrId";
            this.textBoxOgrId.Size = new System.Drawing.Size(197, 36);
            this.textBoxOgrId.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDersEkle);
            this.groupBox2.Controls.Add(this.textBoxDersAd);
            this.groupBox2.Controls.Add(this.textBoxDersId);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(268, 484);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 152);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dersler";
            // 
            // buttonDersEkle
            // 
            this.buttonDersEkle.Location = new System.Drawing.Point(22, 63);
            this.buttonDersEkle.Name = "buttonDersEkle";
            this.buttonDersEkle.Size = new System.Drawing.Size(75, 66);
            this.buttonDersEkle.TabIndex = 14;
            this.buttonDersEkle.Text = "Ders Ekle";
            this.buttonDersEkle.UseVisualStyleBackColor = true;
            this.buttonDersEkle.Click += new System.EventHandler(this.buttonDersEkle_Click);
            // 
            // textBoxDersAd
            // 
            this.textBoxDersAd.Location = new System.Drawing.Point(152, 93);
            this.textBoxDersAd.Name = "textBoxDersAd";
            this.textBoxDersAd.Size = new System.Drawing.Size(197, 36);
            this.textBoxDersAd.TabIndex = 13;
            // 
            // textBoxDersId
            // 
            this.textBoxDersId.Location = new System.Drawing.Point(152, 51);
            this.textBoxDersId.Name = "textBoxDersId";
            this.textBoxDersId.Size = new System.Drawing.Size(197, 36);
            this.textBoxDersId.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxOrtalama);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxDurum);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxSinav3);
            this.groupBox3.Controls.Add(this.textBoxSinav1);
            this.groupBox3.Controls.Add(this.textBoxSinav2);
            this.groupBox3.Controls.Add(this.buttonNotGuncelle);
            this.groupBox3.Controls.Add(this.buttonHesapla);
            this.groupBox3.Location = new System.Drawing.Point(629, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 371);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notlar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Durum:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ortalama:";
            // 
            // textBoxOrtalama
            // 
            this.textBoxOrtalama.Location = new System.Drawing.Point(152, 149);
            this.textBoxOrtalama.Name = "textBoxOrtalama";
            this.textBoxOrtalama.Size = new System.Drawing.Size(197, 36);
            this.textBoxOrtalama.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sınav 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sınav 2:";
            // 
            // textBoxDurum
            // 
            this.textBoxDurum.Location = new System.Drawing.Point(152, 191);
            this.textBoxDurum.Name = "textBoxDurum";
            this.textBoxDurum.Size = new System.Drawing.Size(197, 36);
            this.textBoxDurum.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sınav 1:";
            // 
            // textBoxSinav3
            // 
            this.textBoxSinav3.Location = new System.Drawing.Point(152, 107);
            this.textBoxSinav3.Name = "textBoxSinav3";
            this.textBoxSinav3.Size = new System.Drawing.Size(197, 36);
            this.textBoxSinav3.TabIndex = 16;
            // 
            // textBoxSinav1
            // 
            this.textBoxSinav1.Location = new System.Drawing.Point(152, 23);
            this.textBoxSinav1.Name = "textBoxSinav1";
            this.textBoxSinav1.Size = new System.Drawing.Size(197, 36);
            this.textBoxSinav1.TabIndex = 14;
            // 
            // textBoxSinav2
            // 
            this.textBoxSinav2.Location = new System.Drawing.Point(152, 65);
            this.textBoxSinav2.Name = "textBoxSinav2";
            this.textBoxSinav2.Size = new System.Drawing.Size(197, 36);
            this.textBoxSinav2.TabIndex = 15;
            // 
            // buttonNotGuncelle
            // 
            this.buttonNotGuncelle.Location = new System.Drawing.Point(75, 312);
            this.buttonNotGuncelle.Name = "buttonNotGuncelle";
            this.buttonNotGuncelle.Size = new System.Drawing.Size(274, 52);
            this.buttonNotGuncelle.TabIndex = 20;
            this.buttonNotGuncelle.Text = "Sınav Notu Güncelle";
            this.buttonNotGuncelle.UseVisualStyleBackColor = true;
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.Location = new System.Drawing.Point(75, 254);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(274, 52);
            this.buttonHesapla.TabIndex = 19;
            this.buttonHesapla.Text = "Hesapla";
            this.buttonHesapla.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 649);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Prosedür";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 731);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonNotListele);
            this.Controls.Add(this.buttonDersListele);
            this.Controls.Add(this.buttonBul);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.buttonOgrListe);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonOgrListe;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonBul;
        private System.Windows.Forms.Button buttonDersListele;
        private System.Windows.Forms.Button buttonNotListele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxOgrFotograf;
        private System.Windows.Forms.TextBox textBoxOgrSoyad;
        private System.Windows.Forms.TextBox textBoxOgrAd;
        private System.Windows.Forms.TextBox textBoxOgrId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxDersAd;
        private System.Windows.Forms.TextBox textBoxDersId;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxDurum;
        private System.Windows.Forms.TextBox textBoxSinav3;
        private System.Windows.Forms.TextBox textBoxSinav1;
        private System.Windows.Forms.TextBox textBoxSinav2;
        private System.Windows.Forms.Button buttonNotGuncelle;
        private System.Windows.Forms.Button buttonHesapla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOrtalama;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDersEkle;
        private System.Windows.Forms.Button button1;
    }
}

