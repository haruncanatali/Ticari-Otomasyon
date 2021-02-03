using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Entities.Concrete;
using TicariOtomasyon.DataAccess.Abstract;

namespace TicariOtomasyon.DataAccess.Concrete
{
    public class IlceDal : IIlceDal
    {

        SqlBaglantisi baglanti;

        public IlceDal(SqlBaglantisi x)
        {
            baglanti = x;
        }

        public List<Ilce> List(int id)
        {
            List<Ilce> ilceler = new List<Ilce>();

            SqlCommand komut = new SqlCommand("select * from Tbl_Ilce where SEHIRID=@p1", baglanti.BaglantiDondur());
            komut.Parameters.AddWithValue("@p1", id);
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                ilceler.Add(new Ilce
                {
                    ID = int.Parse(okuyucu[0].ToString()),
                    ILCE = okuyucu[1].ToString(),
                    SEHIRID = int.Parse(okuyucu[2].ToString())
                });
            }
            baglanti.BaglantiDondur().Close();

            return ilceler;
        }
    }
}
