using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicariOtomasyon.DesktopUI.Siniflar
{
    public class SqlBaglantisi
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-SL1S3RQ\SQLEXPRESS;Initial Catalog=DboTicariOtomasyon;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
