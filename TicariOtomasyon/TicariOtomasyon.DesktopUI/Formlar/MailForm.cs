using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon.DesktopUI.Formlar
{
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
        }

        private void mailGonderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mesaj = new MailMessage();
                SmtpClient alici = new SmtpClient();

                alici.Credentials = new System.Net.NetworkCredential("haruncan.atali@gmail.com", "xxxxxxxxxxxxxxxxxxxx");
                alici.Port = 587;
                alici.Host = "smtp.live.com";
                alici.EnableSsl = true;

                mesaj.To.Add(mailTxt.Text.ToString());
                mesaj.From = new MailAddress("haruncan.atali@gmail.com");
                mesaj.Subject = konuTxt.Text.ToString();
                mesaj.Body = mesajTxt.Text.ToString();

                alici.Send(mesaj);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Mesaj gönderilemedi.Lütfen daha sonra tekrar deneyiniz.Hata Mesajı :" + exception.Message);
            }
        }
    }
}
