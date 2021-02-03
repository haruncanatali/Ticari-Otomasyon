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
    public partial class FirmalarForm : Form
    {
        int id = -1;
        IFirmaService _firmaServis;
        IIlceService _ilceServis;
        IIlService _ilServis;
        IOzelKodService _ozelKodServis;
        public FirmalarForm()
        {
            InitializeComponent();
            _firmaServis = InstanceFactory.GetInstance<IFirmaService>();
            _ilceServis = InstanceFactory.GetInstance<IIlceService>();
            _ilServis = InstanceFactory.GetInstance<IIlService>();
            _ozelKodServis = InstanceFactory.GetInstance<IOzelKodService>();
        }

        private void FirmalarForm_Load(object sender, EventArgs e)
        {
            BindData();
            IlCek();
            KodAciklamalariEkle();
        }

        private void KodAciklamalariEkle()
        {
            var entity = _ozelKodServis.Get();
            richKod1.Text = entity.FIRMAKOD1;
            richKod2.Text = entity.FIRMAKOD2;
            richKod3.Text = entity.FIRMAKOD3;
        }

        private void IlCek()
        {
            foreach (var item in _ilServis.List())
            {
                ilCbx.Properties.Items.Add(item.SEHIR);
            }
        }

        private void BindData()
        {
            gridControl1.DataSource = _firmaServis.List();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            id = int.Parse(dr["ID"].ToString());
            firmaAdTxt.Text = dr["AD"].ToString();
            yetkiliTcNoTxt.Text = dr["YETKILITC"].ToString();
            firmaSektorTxt.Text = dr["SEKTOR"].ToString();
            yetkiliStatuTxt.Text = dr["YETKILISTATU"].ToString();
            yetkiliAdTxt.Text = dr["YETKILIADSOYAD"].ToString();
            tel1Txt.Text = dr["TELEFON1"].ToString();
            tel2Txt.Text = dr["TELEFON2"].ToString();
            tel3Txt.Text = dr["TELEFON3"].ToString();
            mailTxt.Text = dr["MAIL"].ToString();
            faxTxt.Text = dr["FAX"].ToString();
            ilCbx.Text = dr["IL"].ToString();
            ilceCbx.Text = dr["ILCE"].ToString();
            adresTxt.Text = dr["ADRES"].ToString();
            vergiDairesiTxt.Text = dr["VERGIDAIRE"].ToString();
            kod1Txt.Text = dr["OZELKOD1"].ToString();
            kod2Txt.Text = dr["OZELKOD2"].ToString();
            kod3Txt.Text = dr["OZELKOD3"].ToString();
        }

        private void ilCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

            ilceCbx.Properties.Items.Clear();

            foreach (var item in _ilceServis.List(ilCbx.SelectedIndex+1))
            {
                ilceCbx.Properties.Items.Add(item.ILCE);
            }
        }

        private void Sil()
        {
            if (id != -1)
            {
                var entity = _firmaServis.Delete(new Firma
                {
                    ID = id
                });

                if (entity != null)
                {
                    MessageBox.Show("Silme işlemi başarılı oldu.");
                    Temizle();
                    BindData();
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silinecek firmayı listeden seçiniz.","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Temizle();
            }
        }

        private void Guncelle()
        {
            if (id != -1)
            {
                var entity = _firmaServis.Add(new Firma
                {
                    ID = id,
                    AD = firmaAdTxt.Text.ToString(),
                    YETKILITC = yetkiliTcNoTxt.Text.ToString(),
                    SEKTOR = firmaSektorTxt.Text.ToString(),
                    YETKILISTATU = yetkiliStatuTxt.Text.ToString(),
                    YETKILIADSOYAD = yetkiliAdTxt.Text.ToString(),
                    TELEFON1 = tel1Txt.Text.ToString(),
                    TELEFON2 = tel2Txt.Text.ToString(),
                    TELEFON3 = tel3Txt.Text.ToString(),
                    MAIL = mailTxt.Text.ToString(),
                    FAX = faxTxt.Text.ToString(),
                    IL = ilCbx.Text.ToString(),
                    ILCE = ilceCbx.Text.ToString(),
                    ADRES = adresTxt.Text.ToString(),
                    VERGIDAIRE = vergiDairesiTxt.Text.ToString(),
                    OZELKOD1 = kod1Txt.Text.ToString(),
                    OZELKOD2 = kod2Txt.Text.ToString(),
                    OZELKOD3 = kod3Txt.Text.ToString()
                });

                if (entity != null)
                {
                    BindData();
                    MessageBox.Show("Güncelleme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız oldu.Girilen değerleri lütfen kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Güncellenecek firma bilgileri için firmayı listeden seçiniz.");
                Temizle();
            }
        }

        private void Kaydet()
        {
            var entity = _firmaServis.Add(new Firma
            {
                AD = firmaAdTxt.Text.ToString(),
                YETKILITC = yetkiliTcNoTxt.Text.ToString(),
                SEKTOR = firmaSektorTxt.Text.ToString(),
                YETKILISTATU = yetkiliStatuTxt.Text.ToString(),
                YETKILIADSOYAD = yetkiliAdTxt.Text.ToString(),
                TELEFON1 = tel1Txt.Text.ToString(),
                TELEFON2 = tel2Txt.Text.ToString(),
                TELEFON3 = tel3Txt.Text.ToString(),
                MAIL = mailTxt.Text.ToString(),
                FAX = faxTxt.Text.ToString(),
                IL = ilCbx.Text.ToString(),
                ILCE = ilceCbx.Text.ToString(),
                ADRES = adresTxt.Text.ToString(),
                VERGIDAIRE = vergiDairesiTxt.Text.ToString(),
                OZELKOD1 = kod1Txt.Text.ToString(),
                OZELKOD2 = kod2Txt.Text.ToString(),
                OZELKOD3 = kod3Txt.Text.ToString()
            });

            if (entity != null)
            {
                BindData();
                MessageBox.Show("Kaydetme işlemi başarılı oldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            else
            {
                MessageBox.Show("Kaydetme işleminde hata meydana geldi.Lütfen girilen değerleri kontrol ediniz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            id = -1;
            firmaAdTxt.Text = "";
            yetkiliTcNoTxt.Text = "";
            firmaSektorTxt.Text = "";
            yetkiliStatuTxt.Text = "";
            yetkiliAdTxt.Text = "";
            tel1Txt.Text = "";
            tel2Txt.Text = "";
            tel3Txt.Text = "";
            mailTxt.Text = "";
            faxTxt.Text = "";
            ilCbx.Text = "";
            ilceCbx.Text = "";
            adresTxt.Text = "";
            vergiDairesiTxt.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
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
    }
}
