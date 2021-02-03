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
    public partial class BankalarForm : Form
    {
        int id = -1;
        IBankaService _bankaServis;
        IIlService _ilServis;
        IIlceService _ilceServis;
        IFirmaService _firmaServis;

        public BankalarForm()
        {
            InitializeComponent();
            _bankaServis = InstanceFactory.GetInstance<IBankaService>();
            _ilServis = InstanceFactory.GetInstance<IIlService>();
            _ilceServis = InstanceFactory.GetInstance<IIlceService>();
            _firmaServis = InstanceFactory.GetInstance<IFirmaService>();
            BindData();
            IlCek();
            FirmaCek();
        }

        private void FirmaCek()
        {
            firmaLookUp.Properties.ValueMember = "ID";
            firmaLookUp.Properties.DisplayMember = "AD";
            firmaLookUp.Properties.DataSource = _firmaServis.ListForBankalarForm();
        }

        private void BindData()
        {
            gridControl1.DataSource = _bankaServis.List();
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
            foreach (var item in _ilceServis.List(ilCbx.SelectedIndex + 1))
            {
                ilceCbx.Properties.Items.Add(item.ILCE);
            }
        }

        private void veritabaniBtns_click(object sender, EventArgs e)
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
            if (id != 1)
            {
                var entity = _bankaServis.Delete(new Banka
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
                    MessageBox.Show("Silme işlemi başarısız oldu.Lütfen daha sonra yeniden deneyin.Hata devam ederse ilgili yazılım sorumlusuna bildirin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek banka verisini listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Temizle();
            }
        }

        private void Guncelle()
        {
            if (id != -1)
            {
                var entity = _bankaServis.Add(new Banka
                {
                    ID = id,
                    BANKAADI = bankaAdTxt.Text.ToString(),
                    IL = ilCbx.Text.ToString(),
                    ILCE = ilceCbx.Text.ToString(),
                    SUBE = subeTxt.Text.ToString(),
                    TELEFON = telefonTxt.Text.ToString(),
                    IBAN = ibanTxt.Text.ToString(),
                    HESAPNO = hesapNoTxt.Text.ToString(),
                    YETKILI = yetkiliTxt.Text.ToString(),
                    TARIH = DateTime.Parse(tarihTxt.Text.ToString()),
                    HESAPTURU = hesapTuruTxt.Text.ToString(),
                    FIRMAID = int.Parse(firmaLookUp.EditValue.ToString())
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
                MessageBox.Show("Lütfen güncellenecek banka bilgisini listeden seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Temizle();
            }
        }

        private void Kaydet()
        {
            var entity = _bankaServis.Add(new Banka
            {
                BANKAADI=bankaAdTxt.Text.ToString(),
                IL=ilCbx.Text.ToString(),
                ILCE=ilceCbx.Text.ToString(),
                SUBE=subeTxt.Text.ToString(),
                TELEFON=telefonTxt.Text.ToString(),
                IBAN=ibanTxt.Text.ToString(),
                HESAPNO=hesapNoTxt.Text.ToString(),
                YETKILI=yetkiliTxt.Text.ToString(),
                TARIH=DateTime.Parse(tarihTxt.Text.ToString()),
                HESAPTURU=hesapTuruTxt.Text.ToString(),
                FIRMAID=int.Parse(firmaLookUp.EditValue.ToString())
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
            id = -1;
            bankaAdTxt.Text = "";
            ilCbx.Text = "";
            ilceCbx.Text = "";
            subeTxt.Text = "";
            telefonTxt.Text = "";
            ibanTxt.Text = "";
            hesapNoTxt.Text = "";
            yetkiliTxt.Text = "";
            tarihTxt.Text = "";
            hesapTuruTxt.Text = "";
            firmaLookUp.Text = "";
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            id = int.Parse(dr["ID"].ToString());
            bankaAdTxt.Text = dr["BANKAADI"].ToString();
            ilCbx.Text = dr["IL"].ToString();
            ilceCbx.Text = dr["ILCE"].ToString();
            subeTxt.Text = dr["SUBE"].ToString();
            telefonTxt.Text = dr["TELEFON"].ToString();
            ibanTxt.Text = dr["IBAN"].ToString();
            hesapNoTxt.Text = dr["HESAPNO"].ToString();
            yetkiliTxt.Text = dr["YETKILI"].ToString();
            tarihTxt.Text = dr["TARIH"].ToString();
            hesapTuruTxt.Text = dr["HESAPTURU"].ToString();
            firmaLookUp.Properties.NullText = dr["Firma Adı"].ToString();
        }
    }
}
