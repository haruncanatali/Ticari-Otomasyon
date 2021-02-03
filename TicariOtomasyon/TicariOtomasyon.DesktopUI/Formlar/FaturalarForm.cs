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
    public partial class FaturalarForm : Form
    {
        int id = -1, id2 = -1;
        IFaturaService _faturaServis;
        IFaturaDetayService _faturaDetayServis;

        public FaturalarForm()
        {
            InitializeComponent();
            _faturaServis = InstanceFactory.GetInstance<IFaturaService>();
            _faturaDetayServis = InstanceFactory.GetInstance<IFaturaDetayService>();
            BindData();
        }

        private void BindData()
        {
            gridControl1.DataSource = _faturaServis.List();
        }

        private void veritabaniBtns_Click(object sender, EventArgs e)
        {
            SimpleButton buton = (SimpleButton)sender;
            switch (buton.Text)
            {
                case "Kaydet":
                    Kaydet();
                    break;
                case "Temizle":
                    Temizle();
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
                var entity = _faturaServis.Delete(new Fatura
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
                    MessageBox.Show("Silme işlemi başarısız oldu.Hatanın devam etmesi durumunda ilgili yazılım sorumlusuyla temasa geçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Silinecek fatura bilgisini lütfen fatura listesinden seçiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Temizle();
            }
        }

        private void Guncelle()
        {
            if (id != -1)
            {
                var entity = _faturaServis.Update(new Fatura
                {
                    ID = id,
                    SERI = seriTxt.Text.ToString(),
                    SIRANO = siraNoTxt.Text.ToString(),
                    TARIH = DateTime.Parse(tarihTxt.Text.ToString()),
                    SAAT = saatTxt.Text.ToString(),
                    VERGIDAIRE = vergiDairesiTxt.Text.ToString(),
                    ALICI = aliciTxt.Text.ToString(),
                    TESLIMEDEN = teslimEdenTxt.Text.ToString(),
                    TESLIMALAN = teslimAlanTxt.Text.ToString()
                });
                if (entity != null)
                {
                    BindData();
                    MessageBox.Show("Güncelleme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız oldu.Lütfen daha sonra tekrar deneyiniz.Hatanın devam etmesi durumunda ilgili yazılım sorumlusuyla temasa geçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek faturayı fatura listesinden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Temizle();
            }

        }

        private void Temizle()
        {
            id = -1;
            id2 = -1;

            seriTxt.Text = "";
            siraNoTxt.Text = "";
            tarihTxt.Text = "";
            saatTxt.Text = "";
            vergiDairesiTxt.Text = "";
            aliciTxt.Text = "";
            teslimEdenTxt.Text = "";
            teslimAlanTxt.Text = "";

            urunAdTxt.Text = "";
            urunMiktarTxt.Text = "";
            urunFiyatTxt.Text = "";
            urunTutarTxt.Text = "";
            faturaIdTxt.Text = "";

            gridControl2.DataSource = null;
            gridControl2.Refresh();
        }

        private void Kaydet()
        {

            var entity = _faturaServis.Add(new Fatura
            {
                SERI = seriTxt.Text.ToString(),
                SIRANO = siraNoTxt.Text.ToString(),
                TARIH = DateTime.Parse(tarihTxt.Text.ToString()),
                SAAT = saatTxt.Text.ToString(),
                VERGIDAIRE = vergiDairesiTxt.Text.ToString(),
                ALICI = aliciTxt.Text.ToString(),
                TESLIMEDEN = teslimEdenTxt.Text.ToString(),
                TESLIMALAN = teslimAlanTxt.Text.ToString()
            });

            if (entity != null)
            {
                BindData();
                MessageBox.Show("Kaydetme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            else
            {
                MessageBox.Show("Kaydetme işlemi başarısız oldu.Lütfen girilen değerleri kontrol ediniz.Hatanın devam etmesi durumunda yazılım sorumlusuyla temasa geçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void veritabani2Btns_Click(object sender, EventArgs e)
        {
            SimpleButton buton = (SimpleButton)sender;
            switch (buton.Text)
            {
                case "Temizle":
                    Temizle();
                    break;
                case "Kaydet":
                    Kaydet2();
                    break;
                case "Güncelle":
                    Guncelle2();
                    break;
                case "Sil":
                    Sil2();
                    break;
            }
        }

        private void Sil2()
        {
            if (id2 != -1)
            {
                var entity2 = _faturaDetayServis.Delete(new FaturaDetay
                {
                    ID=id2,
                });

                if (entity2 != null)
                {
                    MessageBox.Show("Silme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    BindData();
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız oldu.Lütfen daha sonra deneyiniz.Hatanın devam etmesi durumunda yazılım sorumlusuna başvurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Lütfen silinecek fatura detayını fatura detayları listesinden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Temizle();
            }
        }

        private void Guncelle2()
        {
            if (id2 != -1)
            {
                var entity = _faturaDetayServis.Update(new FaturaDetay
                {
                    URUNAD=urunAdTxt.Text.ToString(),
                    MIKTAR=int.Parse(urunMiktarTxt.Text.ToString()),
                    FIYAT=decimal.Parse(urunFiyatTxt.Text.ToString()),
                    TUTAR=decimal.Parse(urunTutarTxt.Text.ToString()),
                    FATURAID=int.Parse(faturaIdTxt.Text.ToString()),
                    ID=id2
                });

                if (entity != null)
                {
                    MessageBox.Show("Güncelleme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız oldu.Lütfen daha sonra deneyiniz.Hatanın devam etmesi durumunda yazılım sorumlusuna başvurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek fatura detayını fatura detayları listesinden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Temizle();
            }
        }

        private void Kaydet2()
        {
            var entity = _faturaDetayServis.Add(new FaturaDetay
            {
                URUNAD = urunAdTxt.Text.ToString(),
                MIKTAR = int.Parse(urunMiktarTxt.Text.ToString()),
                FIYAT = decimal.Parse(urunFiyatTxt.Text.ToString()),
                TUTAR = decimal.Parse(urunTutarTxt.Text.ToString()),
                FATURAID = int.Parse(faturaIdTxt.Text.ToString()),
            });

            if (entity != null)
            {
                MessageBox.Show("Kaydetme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            else
            {
                MessageBox.Show("Kaydetme işlemi başarısız oldu.Lütfen daha sonra deneyiniz.Hatanın devam etmesi durumunda yazılım sorumlusuna başvurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["ID"].ToString());
            seriTxt.Text = dr["SERI"].ToString();
            siraNoTxt.Text = dr["SIRANO"].ToString();
            tarihTxt.Text = dr["TARIH"].ToString();
            saatTxt.Text = dr["SAAT"].ToString();
            vergiDairesiTxt.Text = dr["VERGIDAIRE"].ToString();
            aliciTxt.Text = dr["ALICI"].ToString();
            teslimAlanTxt.Text = dr["TESLIMALAN"].ToString();
            teslimEdenTxt.Text = dr["TESLIMEDEN"].ToString();

            FaturaDetaylariYukle();

        }

        private void FaturaDetaylariYukle()
        {
            gridControl2.DataSource = _faturaDetayServis.ListForFaturalarForm(id);
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            id2 = int.Parse(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns[0]).ToString());
            urunAdTxt.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns[1]).ToString();
            urunMiktarTxt.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns[2]).ToString();
            urunFiyatTxt.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns[3]).ToString();
            urunTutarTxt.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns[4]).ToString();
            faturaIdTxt.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gridView2.Columns[5]).ToString();

        }
    }


    
}
