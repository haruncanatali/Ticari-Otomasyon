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
    public partial class NotlarForm : Form
    {

        int id = -1;
        INotlarService _notlarServis;

        public NotlarForm()
        {
            InitializeComponent();
            _notlarServis = InstanceFactory.GetInstance<INotlarService>();
        }

        private void veritabaniBtns_Clicl(object sender, EventArgs e)
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

        private void Guncelle()
        {
            if (id != -1)
            {
                var entity = _notlarServis.Update(new Notlar
                {
                    ID = id,
                    TARIH = DateTime.Parse(tarihTxt.Text.ToString()),
                    SAAT = saatTxt.Text.ToString(),
                    BASLIK = baslikTxt.Text.ToString(),
                    DETAY = detayTxt.Text.ToString(),
                    OLUSTURAN = olusturanTxt.Text.ToString(),
                    HITAP = hitapTxt.Text.ToString()
                });

                if (entity != null)
                {
                    BindData();
                    MessageBox.Show("Güncelleme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız oldu.Lütfen girilen değerleri kontrol ediniz.Hatanın devam etmesi durumunda yazılım sorumlusu ile temasa geçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek not bilgisini not listesinden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Temizle();
            }
        }

        private void Sil()
        {
            if (id != -1)
            {
                var entity = _notlarServis.Delete(new Notlar
                {
                    ID = id,
                });

                if (entity != null)
                {
                    BindData();
                    MessageBox.Show("Silme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız oldu.Lütfen girilen değerleri kontrol ediniz.Hatanın devam etmesi durumunda yazılım sorumlusu ile temasa geçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek not bilgisini not listesinden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Temizle();
            }
        }

        private void Kaydet()
        {
            var entity = _notlarServis.Add(new Notlar
            {
                TARIH = DateTime.Parse(tarihTxt.Text.ToString()),
                SAAT = saatTxt.Text.ToString(),
                BASLIK = baslikTxt.Text.ToString(),
                DETAY = detayTxt.Text.ToString(),
                OLUSTURAN = olusturanTxt.Text.ToString(),
                HITAP = hitapTxt.Text.ToString()
            });

            if (entity != null)
            {
                BindData();
                MessageBox.Show("Kaydetme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            else
            {
                MessageBox.Show("Kaydetme işlemi başarısız oldu.Lütfen girilen değerleri kontrol ediniz.Hatanın devam etmesi durumunda yazılım sorumlusu ile temasa geçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            id = -1;
            tarihTxt.Text = "";
            saatTxt.Text = "";
            baslikTxt.Text = "";
            olusturanTxt.Text = "";
            hitapTxt.Text = "";
            detayTxt.Text = "";
            _detayTxt.Text = "";
        }

        private void NotlarForm_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gridControl1.DataSource = _notlarServis.List();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["ID"].ToString());
            tarihTxt.Text = dr["TARIH"].ToString();
            saatTxt.Text = dr["SAAT"].ToString();
            baslikTxt.Text = dr["BASLIK"].ToString();
            olusturanTxt.Text = dr["OLUSTURAN"].ToString();
            hitapTxt.Text = dr["HITAP"].ToString();
            detayTxt.Text = dr["DETAY"].ToString();
            _detayTxt.Text = dr["DETAY"].ToString();
        }

        private void saatCek_Click(object sender, EventArgs e)
        {
            string zaman = null;
            zaman = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
            saatTxt.Text = zaman;
        }
    }
}
