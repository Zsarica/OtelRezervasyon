namespace OtelRezervasyon
{
    partial class MusteriForm
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
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.btnDevamEt = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtePosta = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.grpOzetBılgı = new System.Windows.Forms.GroupBox();
            this.lblOzetBilgi = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblFiyatGoster = new System.Windows.Forms.Label();
            this.grpOzetBılgı.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(22, 41);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(26, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(152, 38);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(132, 20);
            this.txtAd.TabIndex = 1;
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(419, 116);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(188, 21);
            this.cmbSehir.TabIndex = 2;
            // 
            // btnDevamEt
            // 
            this.btnDevamEt.Location = new System.Drawing.Point(532, 378);
            this.btnDevamEt.Name = "btnDevamEt";
            this.btnDevamEt.Size = new System.Drawing.Size(75, 23);
            this.btnDevamEt.TabIndex = 3;
            this.btnDevamEt.Text = "Devam Et";
            this.btnDevamEt.UseVisualStyleBackColor = true;
            this.btnDevamEt.Click += new System.EventHandler(this.btnDevamEt_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(152, 64);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(132, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(152, 90);
            this.txtTel.MaxLength = 11;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(132, 20);
            this.txtTel.TabIndex = 1;
            // 
            // txtePosta
            // 
            this.txtePosta.Location = new System.Drawing.Point(152, 116);
            this.txtePosta.MaxLength = 30;
            this.txtePosta.Name = "txtePosta";
            this.txtePosta.Size = new System.Drawing.Size(132, 20);
            this.txtePosta.TabIndex = 1;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(22, 67);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 0;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(22, 93);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(49, 13);
            this.lblTelefon.TabIndex = 0;
            this.lblTelefon.Text = "Telefon :";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(22, 119);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(49, 13);
            this.lblEposta.TabIndex = 0;
            this.lblEposta.Text = "e Posta :";
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(362, 119);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(37, 13);
            this.lblSehir.TabIndex = 0;
            this.lblSehir.Text = "Şehir :";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(362, 41);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(40, 13);
            this.lblAdres.TabIndex = 0;
            this.lblAdres.Text = "Adres :";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(419, 38);
            this.txtAdres.MaxLength = 255;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(188, 68);
            this.txtAdres.TabIndex = 1;
            // 
            // grpOzetBılgı
            // 
            this.grpOzetBılgı.Controls.Add(this.lblOzetBilgi);
            this.grpOzetBılgı.Location = new System.Drawing.Point(25, 169);
            this.grpOzetBılgı.Name = "grpOzetBılgı";
            this.grpOzetBılgı.Size = new System.Drawing.Size(316, 188);
            this.grpOzetBılgı.TabIndex = 4;
            this.grpOzetBılgı.TabStop = false;
            this.grpOzetBılgı.Text = "Özet Bilgi";
            // 
            // lblOzetBilgi
            // 
            this.lblOzetBilgi.AutoSize = true;
            this.lblOzetBilgi.Location = new System.Drawing.Point(11, 37);
            this.lblOzetBilgi.Name = "lblOzetBilgi";
            this.lblOzetBilgi.Size = new System.Drawing.Size(35, 13);
            this.lblOzetBilgi.TabIndex = 0;
            this.lblOzetBilgi.Text = "label1";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(451, 378);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 23);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(416, 152);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(35, 13);
            this.lblFiyat.TabIndex = 6;
            this.lblFiyat.Text = "Fiyat :";
            // 
            // lblFiyatGoster
            // 
            this.lblFiyatGoster.AutoSize = true;
            this.lblFiyatGoster.Location = new System.Drawing.Point(466, 152);
            this.lblFiyatGoster.Name = "lblFiyatGoster";
            this.lblFiyatGoster.Size = new System.Drawing.Size(0, 13);
            this.lblFiyatGoster.TabIndex = 7;
            // 
            // MusteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 459);
            this.Controls.Add(this.lblFiyatGoster);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.grpOzetBılgı);
            this.Controls.Add(this.btnDevamEt);
            this.Controls.Add(this.cmbSehir);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtePosta);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.lblEposta);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Name = "MusteriForm";
            this.Text = "Müşteri Kayıt Formu";
            this.Load += new System.EventHandler(this.MusteriForm_Load);
            this.grpOzetBılgı.ResumeLayout(false);
            this.grpOzetBılgı.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.Button btnDevamEt;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtePosta;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.GroupBox grpOzetBılgı;
        private System.Windows.Forms.Label lblOzetBilgi;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblFiyatGoster;
    }
}