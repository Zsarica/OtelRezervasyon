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
    public partial class AnaForm : Form
    {
        RezervasyonDBEntities _db;
        List<ListItem> _musaitOdalar;

        public AnaForm()
        {
            InitializeComponent();
            _db = new RezervasyonDBEntities();
            txtKisiSayisi.KeyPress += Helper.OnlyNumber;

        }

        public static List<Odalar> odalar = new List<Odalar>();
        public static Odalar oda = new Odalar();
        public static List<string> secilenOdalar = new List<string>();
        int toplam;
        public static int _kisiSayisi;
        public static int fiyatToplam;

        private void AnaForm_Load(object sender, EventArgs e)
        {
            cmbYatakTipi.ListControlFill<YatakTipiEnum>();
            cmbOdaTipi.ListControlFill<OdaTipiEnum>();
        }
        
        public void MusaitOda()
        {
            var giris = dtpGiris.Value;
            var cikis = dtpCikis.Value;
            var rezervasyonlar = (from rez in _db.RezervasyonBilgileris
                                  where (rez.GirisTarihi <= giris && rez.CikisTarihi >= cikis) ||
                                  (rez.GirisTarihi > giris && rez.GirisTarihi >= cikis) ||
                                   (rez.CikisTarihi <= giris && rez.CikisTarihi > cikis) ||
                                   (giris < rez.GirisTarihi && cikis > rez.CikisTarihi)
                                  select rez.RezervasyonID).ToList();

            var doluOdalar = (from rezo in _db.RezervasyonDetays
                              where rezervasyonlar.Contains(rezo.RezervasyonID.Value)
                              select rezo.OdaID).Distinct().ToList();

            var _musaitOdalar = (from o in _db.OdaBilgileris
                             where !doluOdalar.Contains(o.OdaID)
                             && o.YatakTipiEnum == (byte)(YatakTipiEnum)cmbYatakTipi.SelectedValue
                             && o.OdaTipiEnum == (byte)(OdaTipiEnum)cmbOdaTipi.SelectedValue 
                                 select new ListItem{ Text = o.OdaID.ToString(),Value = o.OdaID }).ToList();
                

            cmbOdaSec.DataSource = _musaitOdalar;
            cmbOdaSec.ValueMember = "Value";
            cmbOdaSec.DisplayMember = "Text";
            
            
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            #region Validation
            string hataMesaji = "";
            if (string.IsNullOrWhiteSpace(txtKisiSayisi.Text))
            {
                hataMesaji += "Kişi Sayısı boş geçilemez\n";
            }
            if (string.IsNullOrWhiteSpace(cmbOdaTipi.Text))
            {
                hataMesaji += "Oda Tipi boş geçilemez\n";
            }
            if (string.IsNullOrWhiteSpace(cmbYatakTipi.Text))
            {
                hataMesaji += "Yatak Tipi boş geçilemez\n";
            }
            if (hataMesaji.Length > 0)
            {
                MessageBox.Show(hataMesaji);
                return;
            }
            #endregion

            fiyatToplam = 0;
            foreach (string l in lstOdaEkle.Items)
            {
                int id = Convert.ToInt32(l.Substring(0, 2));
                var fiyatEkle = _db.OdaBilgileris.Where(o => o.OdaID == id).Select(o => o.Fiyat).FirstOrDefault();
                fiyatToplam = fiyatToplam + Convert.ToInt32(fiyatEkle);
            }

            oda.Giris = dtpGiris.Value;
            oda.Cikis = dtpCikis.Value;
            oda.YatakTipi = (YatakTipiEnum)cmbYatakTipi.SelectedValue;
            oda.OdaTipi = (OdaTipiEnum)cmbOdaTipi.SelectedValue;
            oda.KisiSayisi = Convert.ToInt32(txtKisiSayisi.Text);

            _kisiSayisi = Convert.ToInt32(txtKisiSayisi.Text);

            foreach (string l in lstOdaEkle.Items)
            {
                secilenOdalar.Add(l);
            }

            if (toplam < Convert.ToInt32(txtKisiSayisi.Text))
            {
                MessageBox.Show("Yeterli oda seçmediniz");
            }
            else
            {
                MusteriForm musteriForm = new MusteriForm();
                musteriForm.Show();
            }

            
        }

        private void cmbOdaTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            MusaitOda();
        }
        
        
        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKisiSayisi.Text))
            {
                MessageBox.Show("Kişi Sayısı Giriniz");
            }
            else
            {
                       if (lstOdaEkle.Items.Contains(cmbOdaSec.SelectedValue.ToString()+" numaralı oda"))
                        {
                            MessageBox.Show("Bu odayı eklediniz..");
                        }
                        else
                        {
                            lstOdaEkle.Items.Add(cmbOdaSec.SelectedValue.ToString() + " numaralı oda");
                        }


                toplam = 0;
                foreach (string l in lstOdaEkle.Items)
                {
                    int id = Convert.ToInt32(l.Substring(0, 2));
                    var odaEkle = _db.OdaBilgileris.Where(o => o.OdaID == id).Select(o => o.OdaTipiEnum).FirstOrDefault();
                    toplam = toplam + Convert.ToInt32(odaEkle);
                }
                if (toplam > Convert.ToInt32(txtKisiSayisi.Text)*3)
                {
                    int id = Convert.ToInt32(lstOdaEkle.Items[lstOdaEkle.Items.Count - 1].ToString().Substring(0, 2));
                    var odaEkle = _db.OdaBilgileris.Where(o => o.OdaID == id).Select(o => o.OdaTipiEnum).FirstOrDefault();
                    MessageBox.Show("Kişi sayısını kontrol ediniz.");
                    lstOdaEkle.Items.RemoveAt(lstOdaEkle.Items.Count - 1);
                    toplam = toplam - Convert.ToInt32(odaEkle);
                }
                MusaitOda();
            }
        }

        private void btnOdaSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult onay = MessageBox.Show("Oda Silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                  

                    int id = Convert.ToInt32(lstOdaEkle.Items[lstOdaEkle.Items.Count - 1].ToString().Substring(0, 2));
                    var odaEkle = _db.OdaBilgileris.Where(o => o.OdaID == id).Select(o => o.OdaTipiEnum).FirstOrDefault();
                    toplam = toplam - Convert.ToInt32(odaEkle);
                    int satirno = lstOdaEkle.SelectedIndex;
                    lstOdaEkle.Items.RemoveAt(satirno);
                }

            }catch
            {
                MessageBox.Show("İptal Etmek İstediğiniz Odayı Seçiniz");
            }
        }

        private void cmbOdaSec_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MusaitOda();
        }

        private void dtpCikis_ValueChanged(object sender, EventArgs e)
        {
            if(dtpCikis.Value < dtpGiris.Value)
            {
                DialogResult result = MessageBox.Show("Giriş Tarihi Çıkış Tarihinden Büyük Olamaz", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if(result == DialogResult.OK)
                {

                    dtpCikis.Value = dtpGiris.Value;
                }
            }
            if(dtpGiris.Value < DateTime.Now.AddDays(-1) || dtpCikis.Value < DateTime.Now.AddDays(-1))
            {
                DialogResult result = MessageBox.Show("Giriş Tarihi  veya Çıkış Tarihi Bugün Tarihinden Önce Olamaz", "Hatalı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(result == DialogResult.OK)
                {
                    dtpGiris.Value = DateTime.Now;
                    dtpCikis.Value = DateTime.Now;
                }

            }
        }
    }
}
