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
    public partial class PersonelForm : Form
    {

        IPersonelService _personelServis;
        IIlService _ilServis;
        IIlceService _ilceServis;
        int id;

        public PersonelForm()
        {
            InitializeComponent();
            _personelServis = InstanceFactory.GetInstance<IPersonelService>();
            _ilServis = InstanceFactory.GetInstance<IIlService>();
            _ilceServis = InstanceFactory.GetInstance<IIlceService>();
        }

        private void veriTabaniBtns_Click(object sender, EventArgs e)
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
            if (id != -1)
            {
                var entity = _personelServis.Delete(new Personel
                {
                    ID = id
                });

                if (entity != null)
                {
                    MessageBox.Show("Silme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    BindData();
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız oldu.Lütfen girilen değerleri kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silinecek personeli listeden seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Temizle();
            }
        }

        private void Guncelle()
        {
            if (id != -1)
            {
                var entity = _personelServis.Update(new Personel
                {
                    AD = adTxt.Text.ToString(),
                    SOYAD = soyadTxt.Text.ToString(),
                    TELEFON = telefonTxt.Text.ToString(),
                    TC = tcTxt.Text.ToString(),
                    MAIL = mailTxt.Text.ToString(),
                    IL = ilCbx.Text.ToString(),
                    ILCE = ilceCbx.Text.ToString(),
                    ADRES = adresTxt.Text.ToString(),
                    GOREV = gorevTxt.Text.ToString(),
                    ID = id
                });

                if (entity != null)
                {
                    MessageBox.Show("Güncelleme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    BindData();
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız oldu.Lütfen girilen değerleri kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Güncellenecek personeli listeden seçiniz!","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Temizle();
            }
        }

        private void Kaydet()
        {
            var entity = _personelServis.Add(new Personel
            {
                AD = adTxt.Text.ToString(),
                SOYAD = soyadTxt.Text.ToString(),
                TELEFON = telefonTxt.Text.ToString(),
                TC = tcTxt.Text.ToString(),
                MAIL = mailTxt.Text.ToString(),
                IL = ilCbx.Text.ToString(),
                ILCE = ilceCbx.Text.ToString(),
                ADRES = adresTxt.Text.ToString(),
                GOREV = gorevTxt.Text.ToString(),
            });

            if (entity != null)
            {
                MessageBox.Show("Kaydetme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                BindData();
            }
            else
            {
                MessageBox.Show("Kaydetme işlemi başarısız oldu.Lütfen girilen değerleri kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            id = -1;
            adTxt.Text = "";
            soyadTxt.Text = "";
            telefonTxt.Text = "";
            tcTxt.Text = "";
            mailTxt.Text = "";
            gorevTxt.Text = "";
            ilCbx.Text = "";
            ilceCbx.Text = "";
            adresTxt.Text = "";
            
        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {
            BindData();
            IlCek();
        }
        private void BindData()
        {
            gridControl1.DataSource = _personelServis.List();
        }
        private void IlCek()
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
            telefonTxt.Text = dr["TELEFON"].ToString();
            tcTxt.Text = dr["TC"].ToString();
            mailTxt.Text = dr["MAIL"].ToString();
            ilCbx.Text = dr["IL"].ToString();
            ilceCbx.Text = dr["ILCE"].ToString();
            adresTxt.Text = dr["ADRES"].ToString();
            gorevTxt.Text = dr["GOREV"].ToString();
        }
    }
}
