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
    public partial class AyarlarForm : Form
    {
        SqlBaglantisi baglanti;
        int id = -1;
        IAdminService _service;
        public AyarlarForm()
        {
            InitializeComponent();
            baglanti = new SqlBaglantisi();
            _service = InstanceFactory.GetInstance<IAdminService>();
        }

        private void AyarlarForm_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void Temizle()
        {
            id = -1;
            adTxt.Text = "";
            sifreTxt.Text = "";
        }

        private void BindData()
        {
            gridControl1.DataSource = _service.List();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["ID"].ToString());
            adTxt.Text = dr["Username"].ToString();
            sifreTxt.Text = dr["Userkey"].ToString();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                var entity = _service.Add(new Admin
                {
                    Username = adTxt.Text.ToString(),
                    Userkey = sifreTxt.Text.ToString()
                });


                if (entity != null)
                {
                    MessageBox.Show("Kayıt işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kayıt işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Temizle();
                BindData();

            }
            else
            {
                MessageBox.Show("Varolan veriyi tekrar ekleyemessiniz.Olası veri kaybını önlemek için temizle butonuna basabilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            if(id == -1)
            {
                MessageBox.Show("Güncellenecek admin bilgisini admin listesinden seçiniz.", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
                Temizle();
            }
            else
            {
                var entity = _service.Update(new Admin
                {
                    ID = id,
                    Username = adTxt.Text.ToString(),
                    Userkey = sifreTxt.Text.ToString()
                });

                if (entity != null)
                {
                    MessageBox.Show("Güncelleme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    BindData();
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız oldu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
