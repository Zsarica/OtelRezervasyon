namespace OtelRezervasyon
{
    partial class AnaForm
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
            this.dtpGiris = new System.Windows.Forms.DateTimePicker();
            this.lblGiris = new System.Windows.Forms.Label();
            this.lblCikis = new System.Windows.Forms.Label();
            this.dtpCikis = new System.Windows.Forms.DateTimePicker();
            this.cmbOdaTipi = new System.Windows.Forms.ComboBox();
            this.cmbYatakTipi = new System.Windows.Forms.ComboBox();
            this.lblOda = new System.Windows.Forms.Label();
            this.lblYatak = new System.Windows.Forms.Label();
            this.lblOdaSec = new System.Windows.Forms.Label();
            this.cmbOdaSec = new System.Windows.Forms.ComboBox();
            this.btnOdaEkle = new System.Windows.Forms.Button();
            this.lstOdaEkle = new System.Windows.Forms.ListBox();
            this.btnDevam = new System.Windows.Forms.Button();
            this.lblKisiSayisi = new System.Windows.Forms.Label();
            this.txtKisiSayisi = new System.Windows.Forms.TextBox();
            this.btnOdaSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpGiris
            // 
            this.dtpGiris.Location = new System.Drawing.Point(21, 43);
            this.dtpGiris.Name = "dtpGiris";
            this.dtpGiris.Size = new System.Drawing.Size(200, 20);
            this.dtpGiris.TabIndex = 0;
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Location = new System.Drawing.Point(18, 17);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(33, 13);
            this.lblGiris.TabIndex = 1;
            this.lblGiris.Text = "Giriş :";
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Location = new System.Drawing.Point(255, 17);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(35, 13);
            this.lblCikis.TabIndex = 2;
            this.lblCikis.Text = "Çıkış :";
            // 
            // dtpCikis
            // 
            this.dtpCikis.Location = new System.Drawing.Point(258, 43);
            this.dtpCikis.Name = "dtpCikis";
            this.dtpCikis.Size = new System.Drawing.Size(200, 20);
            this.dtpCikis.TabIndex = 3;
            this.dtpCikis.ValueChanged += new System.EventHandler(this.dtpCikis_ValueChanged);
            // 
            // cmbOdaTipi
            // 
            this.cmbOdaTipi.FormattingEnabled = true;
            this.cmbOdaTipi.Location = new System.Drawing.Point(208, 202);
            this.cmbOdaTipi.Name = "cmbOdaTipi";
            this.cmbOdaTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbOdaTipi.TabIndex = 4;
            this.cmbOdaTipi.SelectedIndexChanged += new System.EventHandler(this.cmbOdaTipi_SelectedIndexChanged);
            // 
            // cmbYatakTipi
            // 
            this.cmbYatakTipi.FormattingEnabled = true;
            this.cmbYatakTipi.Location = new System.Drawing.Point(39, 202);
            this.cmbYatakTipi.Name = "cmbYatakTipi";
            this.cmbYatakTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbYatakTipi.TabIndex = 5;
            // 
            // lblOda
            // 
            this.lblOda.AutoSize = true;
            this.lblOda.Location = new System.Drawing.Point(214, 171);
            this.lblOda.Name = "lblOda";
            this.lblOda.Size = new System.Drawing.Size(53, 13);
            this.lblOda.TabIndex = 6;
            this.lblOda.Text = "Oda Tipi :";
            // 
            // lblYatak
            // 
            this.lblYatak.AutoSize = true;
            this.lblYatak.Location = new System.Drawing.Point(36, 171);
            this.lblYatak.Name = "lblYatak";
            this.lblYatak.Size = new System.Drawing.Size(61, 13);
            this.lblYatak.TabIndex = 7;
            this.lblYatak.Text = "Yatak Tipi :";
            // 
            // lblOdaSec
            // 
            this.lblOdaSec.AutoSize = true;
            this.lblOdaSec.Location = new System.Drawing.Point(36, 267);
            this.lblOdaSec.Name = "lblOdaSec";
            this.lblOdaSec.Size = new System.Drawing.Size(55, 13);
            this.lblOdaSec.TabIndex = 8;
            this.lblOdaSec.Text = "Oda Seç :";
            // 
            // cmbOdaSec
            // 
            this.cmbOdaSec.FormattingEnabled = true;
            this.cmbOdaSec.Location = new System.Drawing.Point(39, 294);
            this.cmbOdaSec.Name = "cmbOdaSec";
            this.cmbOdaSec.Size = new System.Drawing.Size(121, 21);
            this.cmbOdaSec.TabIndex = 9;
            this.cmbOdaSec.SelectedIndexChanged += new System.EventHandler(this.cmbOdaSec_SelectedIndexChanged);
            // 
            // btnOdaEkle
            // 
            this.btnOdaEkle.Location = new System.Drawing.Point(192, 292);
            this.btnOdaEkle.Name = "btnOdaEkle";
            this.btnOdaEkle.Size = new System.Drawing.Size(75, 23);
            this.btnOdaEkle.TabIndex = 10;
            this.btnOdaEkle.Text = "Oda Ekle";
            this.btnOdaEkle.UseVisualStyleBackColor = true;
            this.btnOdaEkle.Click += new System.EventHandler(this.btnOdaEkle_Click);
            // 
            // lstOdaEkle
            // 
            this.lstOdaEkle.FormattingEnabled = true;
            this.lstOdaEkle.Location = new System.Drawing.Point(297, 294);
            this.lstOdaEkle.Name = "lstOdaEkle";
            this.lstOdaEkle.Size = new System.Drawing.Size(179, 95);
            this.lstOdaEkle.TabIndex = 11;
            // 
            // btnDevam
            // 
            this.btnDevam.Location = new System.Drawing.Point(526, 407);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(78, 24);
            this.btnDevam.TabIndex = 12;
            this.btnDevam.Text = "Devam Et";
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // lblKisiSayisi
            // 
            this.lblKisiSayisi.AutoSize = true;
            this.lblKisiSayisi.Location = new System.Drawing.Point(36, 99);
            this.lblKisiSayisi.Name = "lblKisiSayisi";
            this.lblKisiSayisi.Size = new System.Drawing.Size(59, 13);
            this.lblKisiSayisi.TabIndex = 6;
            this.lblKisiSayisi.Text = "Kisi Sayısı :";
            // 
            // txtKisiSayisi
            // 
            this.txtKisiSayisi.Location = new System.Drawing.Point(39, 125);
            this.txtKisiSayisi.Name = "txtKisiSayisi";
            this.txtKisiSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtKisiSayisi.TabIndex = 13;
            // 
            // btnOdaSil
            // 
            this.btnOdaSil.Location = new System.Drawing.Point(192, 332);
            this.btnOdaSil.Name = "btnOdaSil";
            this.btnOdaSil.Size = new System.Drawing.Size(75, 23);
            this.btnOdaSil.TabIndex = 14;
            this.btnOdaSil.Text = "Oda Sil";
            this.btnOdaSil.UseVisualStyleBackColor = true;
            this.btnOdaSil.Click += new System.EventHandler(this.btnOdaSil_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 461);
            this.Controls.Add(this.btnOdaSil);
            this.Controls.Add(this.txtKisiSayisi);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.lstOdaEkle);
            this.Controls.Add(this.btnOdaEkle);
            this.Controls.Add(this.cmbOdaSec);
            this.Controls.Add(this.lblOdaSec);
            this.Controls.Add(this.lblYatak);
            this.Controls.Add(this.lblKisiSayisi);
            this.Controls.Add(this.lblOda);
            this.Controls.Add(this.cmbYatakTipi);
            this.Controls.Add(this.cmbOdaTipi);
            this.Controls.Add(this.dtpCikis);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.dtpGiris);
            this.Name = "AnaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpGiris;
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.DateTimePicker dtpCikis;
        private System.Windows.Forms.ComboBox cmbOdaTipi;
        private System.Windows.Forms.ComboBox cmbYatakTipi;
        private System.Windows.Forms.Label lblOda;
        private System.Windows.Forms.Label lblYatak;
        private System.Windows.Forms.Label lblOdaSec;
        private System.Windows.Forms.ComboBox cmbOdaSec;
        private System.Windows.Forms.Button btnOdaEkle;
        private System.Windows.Forms.ListBox lstOdaEkle;
        private System.Windows.Forms.Button btnDevam;
        private System.Windows.Forms.Label lblKisiSayisi;
        private System.Windows.Forms.TextBox txtKisiSayisi;
        private System.Windows.Forms.Button btnOdaSil;
    }
}

