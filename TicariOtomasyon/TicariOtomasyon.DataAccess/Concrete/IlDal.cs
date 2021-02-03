using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Entities.Concrete;
using TicariOtomasyon.DataAccess.Abstract;

namespace TicariOtomasyon.DataAccess.Concrete
{
    public class IlDal : IIlDal
    {

        SqlBaglantisi baglanti;

        public IlDal()
        {
            baglanti = new SqlBaglantisi();
        }

        public List<Il> List()
        {

            List<Il> iller = new List<Il>();

            SqlCommand komut = new SqlCommand("select * from Tbl_Il", baglanti.BaglantiDondur());
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                iller.Add(new Il
                {
                    ID = int.Parse(okuyucu[0].ToString()),
                    SEHIR = okuyucu[1].ToString()
                });
            }
            baglanti.BaglantiDondur().Close();

            return iller;
        }
    }
}
