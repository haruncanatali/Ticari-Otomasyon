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
    public partial class AdminForm : Form
    {
        IAdminService _service;
        public AdminForm()
        {
            InitializeComponent();
            _service = InstanceFactory.GetInstance<IAdminService>();
        }

        private void girisYapBtn_Click(object sender, EventArgs e)
        {
            
            var entity = _service.Get(new Admin
            {
                Username = kullaniciAdiTxt.Text.ToString(),
                Userkey = kullaniciSifreTxt.Text.ToString()
            });

            if (entity!=null)
            {
                Form1 f1 = new Form1();
                f1.adminHeader.Caption = "Admin:" + kullaniciAdiTxt.Text.ToString();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
