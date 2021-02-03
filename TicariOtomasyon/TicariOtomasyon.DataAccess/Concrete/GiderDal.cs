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
    public class GiderDal : IGiderDal
    {

        SqlBaglantisi baglanti;

        public GiderDal()
        {
            baglanti = new SqlBaglantisi();

        }

        public Gider Add(Gider entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Gider(AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti.BaglantiDondur());

                komut.Parameters.AddWithValue("@p1", entity.AY);
                komut.Parameters.AddWithValue("@p2", entity.YIL);
                komut.Parameters.AddWithValue("@p3", entity.ELEKTRIK);
                komut.Parameters.AddWithValue("@p4", entity.SU);
                komut.Parameters.AddWithValue("@p5", entity.DOGALGAZ);
                komut.Parameters.AddWithValue("@p6", entity.INTERNET);
                komut.Parameters.AddWithValue("@p7", entity.MAASLAR);
                komut.Parameters.AddWithValue("@p8", entity.EKSTRA);
                komut.Parameters.AddWithValue("@p9", entity.NOTLAR);

                komut.ExecuteNonQuery();
                baglanti.BaglantiDondur().Close();

                return entity;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Gider Delete(Gider entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("delete from Tbl_Gider where ID=@p1", baglanti.BaglantiDondur());

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

        public Gider Get(Gider entity)
        {
            throw new NotImplementedException();
        }

        public DataTable List()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Tbl_Gider", baglanti.BaglantiDondur());
            adapter.Fill(table);
            baglanti.BaglantiDondur().Close();

            return table;
        }

        public Dictionary<string,decimal> ListForGiderlerFormChart1()
        {

            Dictionary<string, decimal> degerler = new Dictionary<string, decimal>();

            SqlCommand komut = new SqlCommand("select AY,sum(ELEKTRIK+SU+DOGALGAZ+INTERNET+MAASLAR+EKSTRA) as 'Ay Tutarı' from Tbl_Gider group by AY", baglanti.BaglantiDondur());
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                degerler.Add(okuyucu[0].ToString(), decimal.Parse(okuyucu[1].ToString()));
            }
            baglanti.BaglantiDondur().Close();

            return degerler;
        }

        public Gider Update(Gider entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Tbl_Gider set AY=@p1,YIL=@p2,ELEKTRIK=@p3,SU=@p4,DOGALGAZ=@p5,INTERNET=@p6,MAASLAR=@p7,EKSTRA=@p8,NOTLAR=@p9 where ID=@p10", baglanti.BaglantiDondur());

                komut.Parameters.AddWithValue("@p1", entity.AY);
                komut.Parameters.AddWithValue("@p2", entity.YIL);
                komut.Parameters.AddWithValue("@p3", entity.ELEKTRIK);
                komut.Parameters.AddWithValue("@p4", entity.SU);
                komut.Parameters.AddWithValue("@p5", entity.DOGALGAZ);
                komut.Parameters.AddWithValue("@p6", entity.INTERNET);
                komut.Parameters.AddWithValue("@p7", entity.MAASLAR);
                komut.Parameters.AddWithValue("@p8", entity.EKSTRA);
                komut.Parameters.AddWithValue("@p9", entity.NOTLAR);
                komut.Parameters.AddWithValue("@p10", entity.ID);

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
