using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon.DesktopUI.Formlar
{
    public partial class RaporlarForm : Form
    {
        public RaporlarForm()
        {
            InitializeComponent();
        }

        private void RaporlarForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dboTicariOtomasyonDataSet.Tbl_Urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_UrunTableAdapter.Fill(this.dboTicariOtomasyonDataSet.Tbl_Urun);

            this.tbl_PersonelTableAdapter.Fill(this.dboTicariOtomasyonDataSet.Tbl_Personel);

            this.tbl_FirmaTableAdapter.Fill(this.dboTicariOtomasyonDataSet.Tbl_Firma);

            this.tbl_MusteriTableAdapter.Fill(this.dboTicariOtomasyonDataSet.Tbl_Musteri);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
        }
    }
}
