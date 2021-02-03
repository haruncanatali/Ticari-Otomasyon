using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicaretOtomasyonu.Business.Abstract;
using TicaretOtomasyonu.Business.Ninject;
using TicaretOtomasyonu.Entities.Concrete;
using TicariOtomasyon.DesktopUI.Siniflar;

namespace TicariOtomasyon.DesktopUI.Formlar
{
    public partial class GiderlerForm : Form
    {
        int id = -1;
        IGiderService _giderServis;
        public GiderlerForm()
        {
            InitializeComponent();
            _giderServis = InstanceFactory.GetInstance<IGiderService>();
        }

        private void GiderlerForm_Load(object sender, EventArgs e)
        {
            BindData();
            ChartDoldur();
        }

        private void ChartDoldur()
        {
            foreach (var item in _giderServis.ListForGiderlerFormChart1())
            {
                chartControl1.Series["Gider Tutarı"].Points.AddPoint(item.Key,double.Parse(item.Value.ToString()));
            }
        }

        private void BindData()
        {
            gridControl1.DataSource = _giderServis.List();
            ayCbx.SelectedIndex = DateTime.Now.Month-1;
            yilCbx.Text = DateTime.Now.Year.ToString();
        }

        private void veritabaniBtns_Click(object sender, EventArgs e)
        {
            SimpleButton buton = (SimpleButton)sender;
            switch (buton.Text)
            {
                case "Temizle":
                    Temizle();
                    break;
                case "Kaydet":
                    Kaydet();
                    break;
                case "Güncelle":
                    Guncelle();
                    break;
                case "Sil":
                    Sil();
                    break;
            }
        }

        private void Sil()
        {
            if(id != -1)
            {
                var entity = _giderServis.Delete(new Gider
                {
                    ID = id
                });
                if (entity != null)
                {
                    BindData();
                    MessageBox.Show("Silme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız oldu.Lütfen girilen değerleri kontrol ediniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek gider verisi listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Temizle();
            }
            ChartDoldur();
        }

        private void Guncelle()
        {
            if(id != -1)
            {
                var entity = _giderServis.Update(new Gider
                {
                    ID = id,
                    AY = ayCbx.Text.ToString(),
                    YIL = yilCbx.Text.ToString(),
                    ELEKTRIK = decimal.Parse(elektrikTxt.Text.ToString()),
                    SU = decimal.Parse(suTxt.Text.ToString()),
                    DOGALGAZ = decimal.Parse(dogalgazTxt.Text.ToString()),
                    INTERNET = decimal.Parse(internetTxt.Text.ToString()),
                    MAASLAR = decimal.Parse(maasTxt.Text.ToString()),
                    EKSTRA = decimal.Parse(ekstraTxt.Text.ToString()),
                    NOTLAR = notTxt.Text.ToString()
                });
                if (entity != null)
                {
                    BindData();
                    MessageBox.Show("Güncelleme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız oldu.Lütfen girilen değerleri kontrol ediniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek gider bilgisini listeden seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Temizle();
            }

            ChartDoldur();
        }

        private void Kaydet()
        {
            var entity = _giderServis.Add(new Gider
            {
                AY = ayCbx.Text.ToString(),
                YIL = yilCbx.Text.ToString(),
                ELEKTRIK = decimal.Parse(elektrikTxt.Text.ToString()),
                SU = decimal.Parse(suTxt.Text.ToString()),
                DOGALGAZ = decimal.Parse(dogalgazTxt.Text.ToString()),
                INTERNET = decimal.Parse(internetTxt.Text.ToString()),
                MAASLAR = decimal.Parse(maasTxt.Text.ToString()),
                EKSTRA = decimal.Parse(ekstraTxt.Text.ToString()),
                NOTLAR = notTxt.Text.ToString()
            });
            if (entity != null)
            {
                BindData();
                MessageBox.Show("Kaydetme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            else
            {
                MessageBox.Show("Kaydetme işlemi başarısız oldu.Lütfen girilen değerleri kontrol ediniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ChartDoldur();
        }

        private void Temizle()
        {
            id = -1;
            ayCbx.SelectedIndex = DateTime.Now.Month - 1;
            yilCbx.Text = DateTime.Now.Year.ToString();
            elektrikTxt.Text = "";
            suTxt.Text = "";
            dogalgazTxt.Text = "";
            internetTxt.Text = "";
            maasTxt.Text = "";
            ekstraTxt.Text = "";
            notTxt.Text = "";
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["ID"].ToString());
            ayCbx.Text = dr["AY"].ToString();
            yilCbx.Text = dr["YIL"].ToString();
            elektrikTxt.Text = dr["ELEKTRIK"].ToString();
            suTxt.Text = dr["SU"].ToString();
            dogalgazTxt.Text = dr["DOGALGAZ"].ToString();
            internetTxt.Text = dr["INTERNET"].ToString();
            maasTxt.Text = dr["MAASLAR"].ToString();
            ekstraTxt.Text = dr["EKSTRA"].ToString();
            notTxt.Text = dr["NOTLAR"].ToString();
        }
    }
}
