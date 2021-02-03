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
    public partial class MusterilerForm : Form
    {
        int id = -1;

        IIlService _ilServis;
        IIlceService _ilceServis;
        IMusteriService _musteriServis;

        public MusterilerForm()
        {
            InitializeComponent();
            _ilServis = InstanceFactory.GetInstance<IIlService>();
            _ilceServis = InstanceFactory.GetInstance<IIlceService>();
            _musteriServis = InstanceFactory.GetInstance<IMusteriService>();

        }

        private void MusterilerForm_Load(object sender, EventArgs e)
        {
            BindData();
            SehirListesi();
        }

        private void BindData() 
        {
            gridControl1.DataSource = _musteriServis.List();
        }
        private void SehirListesi()
        {
            foreach (var item in _ilServis.List())
            {
                ilCbx.Properties.Items.Add(item.SEHIR);
            }
        }

        private void ilCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceCbx.Properties.Items.Clear();

            foreach (var item in _ilceServis.List(ilCbx.SelectedIndex+1))
            {
                ilceCbx.Properties.Items.Add(item.ILCE);
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            id = int.Parse(dr["ID"].ToString());
            adTxt.Text = dr["AD"].ToString();
            soyadTxt.Text = dr["SOYAD"].ToString();
            telefon1Masked.Text = dr["TELEFON1"].ToString();
            telefon2Masked.Text = dr["TELEFON2"].ToString();
            tcTxt.Text = dr["TC"].ToString();
            mailTxt.Text = dr["MAIL"].ToString();
            ilCbx.Text = dr["IL"].ToString();
            ilceCbx.Text = dr["ILCE"].ToString();
            adresTxt.Text = dr["ADRES"].ToString();
            vergiDairesiTxt.Text = dr["VERGIDAIRE"].ToString();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                var entity = _musteriServis.Delete(new Musteri
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
                    MessageBox.Show("Silme işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden silinecek müsteriyi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            var entity = _musteriServis.Add(new Musteri
            {
                AD = adTxt.Text.ToString(),
                SOYAD = soyadTxt.Text.ToString(),
                TELEFON1 = telefon1Masked.Text.ToString(),
                TELEFON2 = telefon2Masked.Text.ToString(),
                TC = tcTxt.Text.ToString(),
                MAIL = mailTxt.Text.ToString(),
                IL = ilCbx.SelectedText.ToString(),
                ILCE = ilceCbx.SelectedText.ToString(),
                ADRES = adresTxt.Text.ToString(),
                VERGIDAIRE = vergiDairesiTxt.Text.ToString()
            });

            if (entity != null)
            {
                BindData();
                MessageBox.Show("Kaydetme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            else
            {
                MessageBox.Show("Kaydetme işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Temizle()
        {
            adTxt.Text = "";
            soyadTxt.Text = "";
            telefon1Masked.Text = "";
            telefon2Masked.Text = "";
            tcTxt.Text = "";
            mailTxt.Text = "";
            ilCbx.SelectedText = "";
            ilceCbx.SelectedText = "";
            adresTxt.Text = "";
            vergiDairesiTxt.Text = "";
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                var entity = _musteriServis.Update(new Musteri
                {
                    ID = id,
                    AD = adTxt.Text.ToString(),
                    SOYAD = soyadTxt.Text.ToString(),
                    TELEFON1 = telefon1Masked.Text.ToString(),
                    TELEFON2 = telefon2Masked.Text.ToString(),
                    TC = tcTxt.Text.ToString(),
                    MAIL = mailTxt.Text.ToString(),
                    IL = ilCbx.SelectedText.ToString(),
                    ILCE = ilceCbx.SelectedText.ToString(),
                    ADRES = adresTxt.Text.ToString(),
                    VERGIDAIRE = vergiDairesiTxt.Text.ToString()
                });

                if (entity != null)
                {
                    BindData();
                    MessageBox.Show("Güncelleme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden Güncelleme müsteriyi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
