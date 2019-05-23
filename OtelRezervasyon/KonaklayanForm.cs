using OtelRezervasyon.Enums;
using OtelRezervasyon.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelRezervasyon.Enums;
using OtelRezervasyon.Helpers;

namespace OtelRezervasyon
{
    public partial class KonaklayanForm : Form
    {
        RezervasyonDBEntities _db;
        int _count = AnaForm._kisiSayisi;
        //int _say=0;

        public KonaklayanForm()
        {
            InitializeComponent();
            _db = new RezervasyonDBEntities();
            txtAd.KeyPress += Helper.WritingArea;
            txtSoyad.KeyPress += Helper.WritingArea;
            txtTelefon.KeyPress += Helper.OnlyNumber;
            txtTcNo.KeyPress += Helper.OnlyNumber;

        }
       

        public void DatagridDoldur()
        {
            var konaklayanlar = (from kn in _db.Konaklayans
                                 join rkd in _db.RezervasyonKonaklayanDetays on kn.KonaklayanID equals rkd.KonaklayanID
                                 join rd in _db.RezervasyonDetays on rkd.RezervasyonDetayID equals rd.RezervasyonDetayID
                                 join r in _db.RezervasyonBilgileris on rd.RezervasyonID equals r.RezervasyonID
                                 where r.MusteriID == MusteriForm.id
                                 select kn).OrderByDescending(x => x.KonaklayanID).Take(30).ToList();
            dvgKaydet.DataSource = konaklayanlar;
        }


        private void KonaklayanForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.ListControlFill<CinsiyetEnum>();
            cmbSecilenOda.DataSource = AnaForm.secilenOdalar;

            int id = Convert.ToInt32(cmbSecilenOda.SelectedValue.ToString().Substring(0,2));
            var odaTipi = _db.OdaBilgileris.Where(o => o.OdaID == id).Select(o => o.OdaTipiEnum).FirstOrDefault();
            //_say = odaTipi;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int guncellenecekid = Convert.ToInt16(dvgKaydet.CurrentRow.Cells[0].Value);

            Konaklayan guncellenecekKonaklayan = _db.Konaklayans.Find(guncellenecekid);
            guncellenecekKonaklayan.Ad = txtAd.Text.ToLower();
            guncellenecekKonaklayan.Soyad = txtSoyad.Text.ToLower();
            guncellenecekKonaklayan.TcNo = txtTcNo.Text.ToLower();
            guncellenecekKonaklayan.Telefon = txtTelefon.Text.ToLower();
            guncellenecekKonaklayan.Eposta = txtEposta.Text.ToLower();
            guncellenecekKonaklayan.CinsiyetEnum = (byte)(CinsiyetEnum)cmbCinsiyet.SelectedValue;
            guncellenecekKonaklayan.OdaID = Convert.ToInt32(cmbSecilenOda.SelectedValue.ToString().Substring(0, 2));
            _db.SaveChanges();
            DatagridDoldur();

        }
        
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (_count > 0)
            {
                MessageBox.Show("Tüm konaklayan bilgilerini kaydetmediniz.");
            }
            else
            {
                MessageBox.Show("Kayıt işleminiz başarıyla gerçekleştirildi");
            }
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            #region Validation
            string hataMesaji = "";
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                hataMesaji += "Ad boş geçilemez\n";
            }
            if (string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                hataMesaji += "Soyad boş geçilemez\n";
            }
            if (string.IsNullOrWhiteSpace(txtTcNo.Text))
            {
                hataMesaji += "Tc Numarası boş geçilemez\n";
            }
            if (string.IsNullOrWhiteSpace(cmbCinsiyet.Text))
            {
                hataMesaji += "Cinsiyet boş geçilemez\n";
            }
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                hataMesaji += "Telefon boş geçilemez\n";
            }
            if (hataMesaji.Length > 0)
            {
                MessageBox.Show(hataMesaji);
                return;
            }
            #endregion

            //_say--;
            //if (_say == 0)
            //{
            //    AnaForm.secilenOdalar.Remove(cmbSecilenOda.SelectedText);
            //}

            if (_count > 0)
            {
                Konaklayan yeniKonaklayan = new Konaklayan()
                {
                    Ad = txtAd.Text.ToLower(),
                    Soyad = txtSoyad.Text.ToLower(),
                    TcNo = txtTcNo.Text.ToLower(),
                    Telefon = txtTelefon.Text.ToLower(),
                    Eposta = txtEposta.Text.ToLower(),
                    CinsiyetEnum = (byte)(CinsiyetEnum)cmbCinsiyet.SelectedValue,
                    OdaID = Convert.ToInt32(cmbSecilenOda.SelectedValue.ToString().Substring(0, 2))
                };

                _db.Konaklayans.Add(yeniKonaklayan);
                _db.SaveChanges();

                int idKonaklayan = yeniKonaklayan.KonaklayanID;

                RezervasyonDetay yeniRezarvasyonDetay = new RezervasyonDetay()
                {
                    RezervasyonID = MusteriForm.idRezervasyon,
                    OdaID = Convert.ToInt32(cmbSecilenOda.SelectedValue.ToString().Substring(0, 2))
                };

                _db.RezervasyonDetays.Add(yeniRezarvasyonDetay);
                _db.SaveChanges();

                int idYeniRezervasyonDetay = yeniRezarvasyonDetay.RezervasyonDetayID;

                RezervasyonKonaklayanDetay yeniRezKonDetay = new RezervasyonKonaklayanDetay()
                {
                    RezervasyonDetayID = idYeniRezervasyonDetay,
                    KonaklayanID = idKonaklayan
                };

                _db.RezervasyonKonaklayanDetays.Add(yeniRezKonDetay);
                _db.SaveChanges();
                
                _count--;
            }
            else
            {
                MessageBox.Show("Kişi Sayısını Aştınız..");
            }

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTcNo.Text = "";
            txtTelefon.Text = "";
            txtEposta.Text = "";
            cmbCinsiyet.SelectedIndex = -1;
            cmbSecilenOda.SelectedIndex = -1;

            DatagridDoldur();

        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            int silinecekKonaklayanID = Convert.ToInt16(dvgKaydet.CurrentRow.Cells[0].Value);

            Konaklayan silinecekKonaklayan = _db.Konaklayans.Find(silinecekKonaklayanID);
            _db.Konaklayans.Remove(silinecekKonaklayan);
            List<RezervasyonKonaklayanDetay> silnecekDetay = _db.RezervasyonKonaklayanDetays.Where(x => x.KonaklayanID == silinecekKonaklayanID).ToList();
            _db.RezervasyonKonaklayanDetays.RemoveRange(silnecekDetay);
            _db.SaveChanges();
            DatagridDoldur();

        }

        private void dvgKaydet_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dvgKaydet.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dvgKaydet.CurrentRow.Cells[2].Value.ToString();
            txtTcNo.Text = dvgKaydet.CurrentRow.Cells[3].Value.ToString();
            txtEposta.Text = dvgKaydet.CurrentRow.Cells[4].Value.ToString();
            txtTelefon.Text = dvgKaydet.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {

        }
    }
}
