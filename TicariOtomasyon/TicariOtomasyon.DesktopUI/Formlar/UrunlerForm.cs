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
    public partial class UrunlerForm : Form
    {
        int id=-1;
        IUrunService _urunServis;

        public UrunlerForm()
        {
            InitializeComponent();
            _urunServis = InstanceFactory.GetInstance<IUrunService>();
        }

        private void UrunlerForm_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gridControl1.DataSource = _urunServis.List();
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            var entity = _urunServis.Add(new Urun
            {
                URUNAD = adTxt.Text.ToString(),
                URUNMARKA = markaTxt.Text.ToString(),
                MODEL = modelTxt.Text.ToString(),
                YIL = yilTxt.Text.ToString(),
                ADET = int.Parse(adetNumeric.Value.ToString()),
                ALISFIYAT = decimal.Parse(txtAlis.Text.ToString()),
                SATISFIYAT = decimal.Parse(txtSatis.Text.ToString()),
                DETAY = detayTxt.Text.ToString()
            });

            if (entity != null)
            {
                MessageBox.Show("Ürün sisteme eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BindData();
                Temizle();
            }
            else
            {
                MessageBox.Show("Ekleme işleminde hata oluştu.Lütfen değerlerinizi kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            id = int.Parse(dr["ID"].ToString());
            adTxt.Text = dr["URUNAD"].ToString();
            markaTxt.Text = dr["URUNMARKA"].ToString();
            modelTxt.Text = dr["MODEL"].ToString();
            yilTxt.Text = dr["YIL"].ToString();
            adetNumeric.Value = int.Parse(dr["ADET"].ToString());
            txtAlis.Text = dr["ALISFIYAT"].ToString();
            txtSatis.Text = dr["SATISFIYAT"].ToString();
            detayTxt.Text = dr["DETAY"].ToString();

        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            if(id != -1)
            {
                var entity = _urunServis.Update(new Urun
                {
                    ID = id,
                    URUNAD = adTxt.Text.ToString(),
                    URUNMARKA = markaTxt.Text.ToString(),
                    MODEL = modelTxt.Text.ToString(),
                    YIL = yilTxt.Text.ToString(),
                    ADET = int.Parse(adetNumeric.Value.ToString()),
                    ALISFIYAT = decimal.Parse(txtAlis.Text.ToString()),
                    SATISFIYAT = decimal.Parse(txtSatis.Text.ToString()),
                    DETAY = detayTxt.Text.ToString()
                });

                if (entity != null)
                {
                    MessageBox.Show("Ürün güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BindData();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Güncelleme işleminde hata oluştu.Lütfen değerlerinizi kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Güncellenecek ürünü listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Temizle();
            }
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                var entity = _urunServis.Delete(new Urun
                {
                    ID = id
                });

                if (entity != null)
                {
                    MessageBox.Show("Ürün silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BindData();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Silme işleminde hata oluştu.Lütfen değerlerinizi kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silenecek ürünü listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Temizle();
            }
        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            id = -1;
            adTxt.Text = "";
            markaTxt.Text = "";
            modelTxt.Text = "";
            yilTxt.Text = "";
            adetNumeric.Value = 0;
            txtAlis.Text = "";
            txtSatis.Text = "";
            detayTxt.Text = "";
        }
    }
}
