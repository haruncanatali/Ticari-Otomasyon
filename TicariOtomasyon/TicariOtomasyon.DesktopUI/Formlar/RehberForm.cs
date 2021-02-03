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
    public partial class RehberForm : Form
    {

        IFirmaService _firmaServis;
        IMusteriService _musteriServis;

        public RehberForm()
        {
            InitializeComponent();
            _firmaServis = InstanceFactory.GetInstance<IFirmaService>();
            _musteriServis = InstanceFactory.GetInstance<IMusteriService>();
        }

        private void RehberForm_Load(object sender, EventArgs e)
        {
            BindDataMusteri();
            BindDataFirma();
        }

        private void BindDataFirma()
        {
            gridControl2.DataSource = _firmaServis.List();
        }

        private void BindDataMusteri()
        {
            gridControl1.DataSource = _musteriServis.List();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            MailForm mailForm = new MailForm();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr != null)
            {
                mailForm.mailTxt.Text = dr["MAIL"].ToString();
                mailForm.mailTxt.ForeColor = Color.Red;
                mailForm.StartPosition = FormStartPosition.CenterScreen;
                mailForm.Show();
            }
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            MailForm mailForm = new MailForm();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                mailForm.mailTxt.Text = dr["MAIL"].ToString();
                mailForm.mailTxt.ForeColor = Color.Red;
                mailForm.StartPosition = FormStartPosition.CenterScreen;
                mailForm.Show();
            }
        }
    }
}
