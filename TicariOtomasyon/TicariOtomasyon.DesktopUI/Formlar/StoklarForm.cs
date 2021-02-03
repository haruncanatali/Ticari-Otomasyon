using Microsoft.Reporting.WinForms;
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
using TicariOtomasyon.DesktopUI.Siniflar;

namespace TicariOtomasyon.DesktopUI.Formlar
{
    public partial class StoklarForm : Form
    {

        SqlBaglantisi baglanti;
        IUrunService _urunServis;
        IFirmaService _firmaServis;

        public StoklarForm()
        {
            InitializeComponent();
            baglanti = new SqlBaglantisi();
            _urunServis = InstanceFactory.GetInstance<IUrunService>();
            _firmaServis = InstanceFactory.GetInstance<IFirmaService>();
        }

        private void StoklarForm_Load(object sender, EventArgs e)
        {
            BindData();
            ChartYukle();
            ChartYukle2();
        }

        private void ChartYukle2()
        {
            foreach (var item in _firmaServis.ListForStoklarChart2())
            {
                chartControl2.Series["Firma Lokasyonu"].Points.AddPoint(item.Key,double.Parse(item.Value.ToString()));
            }
        }

        private void ChartYukle()
        {
            foreach (var item in _urunServis.ListForStoklarChart1())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(item.Key, double.Parse(item.Value.ToString()));
            }
        }

        private void BindData()
        {
            gridControl1.DataSource = _urunServis.ListForStoklarBind();
        }
    }
}
