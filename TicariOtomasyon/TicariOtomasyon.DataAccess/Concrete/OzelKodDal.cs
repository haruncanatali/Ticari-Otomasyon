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
    public class OzelKodDal : IOzelKodDal
    {
        SqlBaglantisi baglanti;

        public OzelKodDal(SqlBaglantisi x)
        {
            baglanti = x;
        }

        public OzelKod Get()
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Kod", baglanti.BaglantiDondur());
            SqlDataReader okuyucu = komut.ExecuteReader();
            OzelKod entity=new OzelKod();
            while (okuyucu.Read())
            {
                entity.FIRMAKOD1 = okuyucu[1].ToString();
                entity.FIRMAKOD2 = okuyucu[2].ToString();
                entity.FIRMAKOD3 = okuyucu[3].ToString();
            }

            baglanti.BaglantiDondur().Close();

            return entity;

        }
    }
}
