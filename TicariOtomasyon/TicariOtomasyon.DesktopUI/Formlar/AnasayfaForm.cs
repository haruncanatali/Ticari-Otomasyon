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
using System.Xml;
using TicaretOtomasyonu.Business.Abstract;
using TicaretOtomasyonu.Business.Ninject;
using TicariOtomasyon.DesktopUI.Siniflar;

namespace TicariOtomasyon.DesktopUI.Formlar
{
    public partial class AnasayfaForm : Form
    {
        IMusteriService _musteriServis;
        public AnasayfaForm()
        {
            InitializeComponent();
            _musteriServis = InstanceFactory.GetInstance<IMusteriService>();
        }

        private void AnasayfaForm_Load(object sender, EventArgs e)
        {
            BindGridData();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/main+page+site+area/bugun");
            HaberleriYukle();
        }

        private void HaberleriYukle()
        {
            XmlTextReader oku = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");
            while (oku.Read())
            {
                if (oku.Name == "title")
                {
                    listBox1.Items.Add(oku.ReadString());
                }
            }
        }

        private void BindGridData()
        {
            gridControl1.DataSource = _musteriServis.ListForAnasayfa();
        }
    }
}
