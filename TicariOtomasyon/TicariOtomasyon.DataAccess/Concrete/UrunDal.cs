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
    public class UrunDal : IUrunDal
    {

        SqlBaglantisi baglanti;

        public UrunDal()
        {
            baglanti = new SqlBaglantisi();
        }

        public Urun Add(Urun entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Urun(URUNAD,URUNMARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti.BaglantiDondur());

                komut.Parameters.AddWithValue("@p1", entity.URUNAD);
                komut.Parameters.AddWithValue("@p2", entity.URUNMARKA);
                komut.Parameters.AddWithValue("@p3", entity.MODEL);
                komut.Parameters.AddWithValue("@p4", entity.YIL);
                komut.Parameters.AddWithValue("@p5", entity.ADET);
                komut.Parameters.AddWithValue("@p6", entity.ALISFIYAT);
                komut.Parameters.AddWithValue("@p7", entity.SATISFIYAT);
                komut.Parameters.AddWithValue("@p8", entity.DETAY);

                komut.ExecuteNonQuery();

                baglanti.BaglantiDondur().Close();

                return entity;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Urun Delete(Urun entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Delete from Tbl_Urun where ID=@p1", baglanti.BaglantiDondur());
                komut.Parameters.AddWithValue("@p1", entity.ID);
                komut.ExecuteNonQuery();
                baglanti.BaglantiDondur().Close();

                return entity;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Urun Get(Urun entity)
        {
            throw new NotImplementedException();
        }

        public DataTable List()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Tbl_Urun", baglanti.BaglantiDondur());
            adapter.Fill(tablo);
            baglanti.BaglantiDondur().Close();

            return tablo;
        }

        public DataTable ListForStoklarBind()
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select URUNAD,sum(ADET) as 'Miktar' from Tbl_Urun group by URUNAD", baglanti.BaglantiDondur());
            adapter.Fill(tablo);
            baglanti.BaglantiDondur().Close();

            return tablo;
        }

        public Dictionary<string, decimal> ListForStoklarChart1()
        {
            Dictionary<string, decimal> veriler = new Dictionary<string, decimal>();
            SqlCommand komut = new SqlCommand("select URUNAD,sum(ADET) as 'Miktar' from Tbl_Urun group by URUNAD", baglanti.BaglantiDondur());
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                veriler.Add(okuyucu[0].ToString(),decimal.Parse(okuyucu[1].ToString()));
            }
            baglanti.BaglantiDondur().Close();
            return veriler;
        }

        public Urun Update(Urun entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Tbl_Urun set URUNAD=@p1,URUNMARKA=@p2,MODEL=@p3,YIL=@p4,ADET=@p5,ALISFIYAT=@p6,SATISFIYAT=@p7,DETAY=@p8 where ID=@p9", baglanti.BaglantiDondur());

                komut.Parameters.AddWithValue("@p1", entity.URUNAD);
                komut.Parameters.AddWithValue("@p2", entity.URUNMARKA);
                komut.Parameters.AddWithValue("@p3", entity.MODEL);
                komut.Parameters.AddWithValue("@p4", entity.YIL);
                komut.Parameters.AddWithValue("@p5", entity.ADET);
                komut.Parameters.AddWithValue("@p6", entity.ALISFIYAT);
                komut.Parameters.AddWithValue("@p7", entity.SATISFIYAT);
                komut.Parameters.AddWithValue("@p8", entity.DETAY);
                komut.Parameters.AddWithValue("@p9", entity.ID);


                komut.ExecuteNonQuery();

                baglanti.BaglantiDondur().Close();

                return entity;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
