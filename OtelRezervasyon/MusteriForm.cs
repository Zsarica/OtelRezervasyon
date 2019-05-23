using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelRezervasyon.Helpers;

namespace OtelRezervasyon
{
    public partial class MusteriForm : Form
    {
        RezervasyonDBEntities _db;

        public MusteriForm()
        {
            InitializeComponent();
            _db = new RezervasyonDBEntities();
            txtAd.KeyPress += Helper.WritingArea;
            txtSoyad.KeyPress += Helper.WritingArea;
            txtTel.KeyPress += Helper.OnlyNumber;
        }

        public static List<Musteriler> musteriler = new List<Musteriler>();
        public static Musteriler musteri = new Musteriler();
        public static int idRezervasyon;

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            cmbSehir.DataSource = _db.illers.ToList();
            cmbSehir.DisplayMember = "sehir";
            cmbSehir.ValueMember = "id";

            StringBuilder sb = new StringBuilder();
            sb.Append("Giriş Tarihi :");
            sb.AppendLine(AnaForm.oda.Giris.ToString());
            sb.Append("Çıkış Tarihi :");
            sb.AppendLine(AnaForm.oda.Cikis.ToString());
            sb.Append("Yatak Tipi :");
            sb.AppendLine(AnaForm.oda.YatakTipi.ToString());
            sb.Append("Oda Tipi :");
            sb.AppendLine(AnaForm.oda.OdaTipi.ToString());
            sb.Append("Kisi Sayısı :");
            sb.AppendLine(AnaForm.oda.KisiSayisi.ToString());
            sb.Append("Secilen Odalar :");
            foreach (var item in AnaForm.secilenOdalar)
            {
                sb.AppendLine(item.ToString());
            }
           
            lblOzetBilgi.Text = sb.ToString();
            lblFiyatGoster.Text = AnaForm.fiyatToplam.ToString()+" TL";
        }
        
        public static int id;
        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            #region
            string hataMesaji = "";
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                hataMesaji += "Adınızı Giriniz\n";
            }
            if (string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                hataMesaji += "Soyadınızı Giriniz\n";
            }
            if (string.IsNullOrWhiteSpace(txtTel.Text))
            {
                hataMesaji += "Telefon Numaranızı Giriniz\n";
            }
            if (string.IsNullOrWhiteSpace(txtAdres.Text))
            {
                hataMesaji += "Adresinizi Giriniz\n";
            }
            if (string.IsNullOrWhiteSpace(cmbSehir.Text))
            {
                hataMesaji += "Şehir Seçiniz\n";
            }
            if (hataMesaji.Length > 0)
            {
                MessageBox.Show(hataMesaji);
                return;
            }
            #endregion
            musteri.Ad = txtAd.Text;
            musteri.Soyad = txtSoyad.Text;
            musteri.Telefon = txtTel.Text;
            musteri.Eposta = txtePosta.Text;
            musteri.Adres = txtAdres.Text;
            musteri.SehirID = Convert.ToInt32(cmbSehir.SelectedValue);

            KonaklayanForm konaklayan = new KonaklayanForm();
            konaklayan.Show();

            Musteri yeniMusteri = new Musteri()
            {
                Ad = MusteriForm.musteri.Ad.ToLower(),
                Soyad = MusteriForm.musteri.Soyad.ToLower(),
                Telefon = MusteriForm.musteri.Telefon.ToLower(),
                Eposta = MusteriForm.musteri.Eposta.ToLower(),
                Adres = MusteriForm.musteri.Adres.ToLower(),
                SehirID = MusteriForm.musteri.SehirID
            };
            _db.Musteris.Add(yeniMusteri);
            _db.SaveChanges();

            id = yeniMusteri.MusteriID;

            RezervasyonBilgileri yeniRezervasyon = new RezervasyonBilgileri()
            {
                MusteriID = id,
                GirisTarihi = (DateTime)AnaForm.oda.Giris,
                CikisTarihi = (DateTime)AnaForm.oda.Cikis,
                KisiSayisi = AnaForm.oda.KisiSayisi
            };

            _db.RezervasyonBilgileris.Add(yeniRezervasyon);
            _db.SaveChanges();

            idRezervasyon = yeniRezervasyon.RezervasyonID;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaForm anaForm = new AnaForm();
            anaForm.Show();
            this.Close();





        }
    }
}
