using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicariOtomasyon.DesktopUI.Formlar;

namespace TicariOtomasyon.DesktopUI
{
    public partial class Form1 : Form
    {

        UrunlerForm _urunlerForm;
        MusterilerForm _musterilerForm;
        FirmalarForm _firmalarForm;
        PersonelForm _personellerForm;
        RehberForm _rehberForm;
        GiderlerForm _giderlerForm;
        BankalarForm _bankalarForm;
        FaturalarForm _faturalarForm;
        NotlarForm _notlarForm;
        RaporlarForm _raporlarForm;
        StoklarForm _stoklarForm;
        AyarlarForm _ayarlarForm;
        AnasayfaForm _anasayfaForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                _urunlerForm = new UrunlerForm();
                _urunlerForm.MdiParent = this;
                _urunlerForm.Show();
            
        }

        private void btnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                _musterilerForm = new MusterilerForm();
                _musterilerForm.MdiParent = this;
                _musterilerForm.Show();
           
        }

        private void btnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
                _firmalarForm = new FirmalarForm();
                _firmalarForm.MdiParent = this;
                _firmalarForm.Show();
           
        }

        private void btnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
    
                _personellerForm = new PersonelForm();
                _personellerForm.MdiParent = this;
                _personellerForm.Show();
           
        }

        private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

                _rehberForm = new RehberForm();
                _rehberForm.MdiParent = this;
                _rehberForm.Show();
          
        }

        private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

                _giderlerForm = new GiderlerForm();
                _giderlerForm.MdiParent = this;
                _giderlerForm.Show();
            
        }

        private void btnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

                _bankalarForm = new BankalarForm();
                _bankalarForm.MdiParent = this;
                _bankalarForm.Show();
           
        }

        private void btnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

                _faturalarForm = new FaturalarForm();
                _faturalarForm.MdiParent = this;
                _faturalarForm.Show();
         
        }

        private void btnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

                _notlarForm = new NotlarForm();
                _notlarForm.MdiParent = this;
                _notlarForm.Show();
          
        }

        private void btnCikisYap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Sistemden çıkış yapılacak.Eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void btnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

                _stoklarForm = new StoklarForm();
                _stoklarForm.MdiParent = this;
                _stoklarForm.Show();
          
        }

        private void raporlarBtn_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

                _raporlarForm = new RaporlarForm();
                _raporlarForm.MdiParent = this;
                _raporlarForm.Show();
            
        }

        private void btnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

                _ayarlarForm = new AyarlarForm();
                _ayarlarForm.MdiParent = this;
                _ayarlarForm.Show();

        }

        private void btnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _anasayfaForm = new AnasayfaForm();
            _anasayfaForm.MdiParent = this;
            _anasayfaForm.Show();
        }
    }
}
