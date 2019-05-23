namespace OtelRezervasyon
{
    partial class KonaklayanForm
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
            this.dvgKaydet = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.grpKonaklayanlar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbSecilenOda = new System.Windows.Forms.ComboBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.lblSecilenOda = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgKaydet)).BeginInit();
            this.grpKonaklayanlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgKaydet
            // 
            this.dvgKaydet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgKaydet.Location = new System.Drawing.Point(59, 274);
            this.dvgKaydet.Name = "dvgKaydet";
            this.dvgKaydet.Size = new System.Drawing.Size(581, 176);
            this.dvgKaydet.TabIndex = 6;
            this.dvgKaydet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgKaydet_CellContentClick_2);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(661, 275);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(96, 29);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(661, 320);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 29);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(770, 463);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(96, 29);
            this.btnOnayla.TabIndex = 5;
            this.btnOnayla.Text = "Çıkış";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // grpKonaklayanlar
            // 
            this.grpKonaklayanlar.Controls.Add(this.label1);
            this.grpKonaklayanlar.Controls.Add(this.btnKaydet);
            this.grpKonaklayanlar.Controls.Add(this.cmbSecilenOda);
            this.grpKonaklayanlar.Controls.Add(this.cmbCinsiyet);
            this.grpKonaklayanlar.Controls.Add(this.txtTcNo);
            this.grpKonaklayanlar.Controls.Add(this.txtEposta);
            this.grpKonaklayanlar.Controls.Add(this.txtSoyad);
            this.grpKonaklayanlar.Controls.Add(this.txtTelefon);
            this.grpKonaklayanlar.Controls.Add(this.txtAd);
            this.grpKonaklayanlar.Controls.Add(this.lblCinsiyet);
            this.grpKonaklayanlar.Controls.Add(this.lblTcNo);
            this.grpKonaklayanlar.Controls.Add(this.lblSecilenOda);
            this.grpKonaklayanlar.Controls.Add(this.lblEposta);
            this.grpKonaklayanlar.Controls.Add(this.lblSoyad);
            this.grpKonaklayanlar.Controls.Add(this.lblTelefon);
            this.grpKonaklayanlar.Controls.Add(this.lblAd);
            this.grpKonaklayanlar.Location = new System.Drawing.Point(59, 12);
            this.grpKonaklayanlar.Name = "grpKonaklayanlar";
            this.grpKonaklayanlar.Size = new System.Drawing.Size(581, 219);
            this.grpKonaklayanlar.TabIndex = 7;
            this.grpKonaklayanlar.TabStop = false;
            this.grpKonaklayanlar.Text = "Konaklayanlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Konaklayan kişileri giriniz :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(437, 168);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(96, 29);
            this.btnKaydet.TabIndex = 35;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // cmbSecilenOda
            // 
            this.cmbSecilenOda.FormattingEnabled = true;
            this.cmbSecilenOda.Location = new System.Drawing.Point(91, 66);
            this.cmbSecilenOda.Name = "cmbSecilenOda";
            this.cmbSecilenOda.Size = new System.Drawing.Size(121, 21);
            this.cmbSecilenOda.TabIndex = 33;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(403, 61);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(150, 21);
            this.cmbCinsiyet.TabIndex = 34;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(91, 161);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(121, 20);
            this.txtTcNo.TabIndex = 30;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(403, 129);
            this.txtEposta.MaxLength = 20;
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(150, 20);
            this.txtEposta.TabIndex = 31;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(91, 129);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtSoyad.TabIndex = 32;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(403, 95);
            this.txtTelefon.MaxLength = 11;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(150, 20);
            this.txtTelefon.TabIndex = 28;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(91, 98);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(121, 20);
            this.txtAd.TabIndex = 29;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(327, 66);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(49, 13);
            this.lblCinsiyet.TabIndex = 23;
            this.lblCinsiyet.Text = "Cinsiyet :";
            // 
            // lblTcNo
            // 
            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Location = new System.Drawing.Point(24, 168);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(40, 13);
            this.lblTcNo.TabIndex = 24;
            this.lblTcNo.Text = "TcNo :";
            // 
            // lblSecilenOda
            // 
            this.lblSecilenOda.AutoSize = true;
            this.lblSecilenOda.Location = new System.Drawing.Point(14, 69);
            this.lblSecilenOda.Name = "lblSecilenOda";
            this.lblSecilenOda.Size = new System.Drawing.Size(65, 13);
            this.lblSecilenOda.TabIndex = 25;
            this.lblSecilenOda.Text = "Seçilen Oda";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(330, 129);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(46, 13);
            this.lblEposta.TabIndex = 26;
            this.lblEposta.Text = "Eposta :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(24, 136);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(43, 13);
            this.lblSoyad.TabIndex = 27;
            this.lblSoyad.Text = "Soyad :";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(327, 101);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(49, 13);
            this.lblTelefon.TabIndex = 21;
            this.lblTelefon.Text = "Telefon :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(24, 105);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(26, 13);
            this.lblAd.TabIndex = 22;
            this.lblAd.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Konaklayanlar :";
            // 
            // KonaklayanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpKonaklayanlar);
            this.Controls.Add(this.dvgKaydet);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.btnSil);
            this.Name = "KonaklayanForm";
            this.Text = "KonaklayanForm";
            this.Load += new System.EventHandler(this.KonaklayanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgKaydet)).EndInit();
            this.grpKonaklayanlar.ResumeLayout(false);
            this.grpKonaklayanlar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dvgKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.GroupBox grpKonaklayanlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbSecilenOda;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.Label lblSecilenOda;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label2;
    }
}