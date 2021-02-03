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
    public class FirmaDal : IFirmaDal
    {

        SqlBaglantisi baglanti;
        public FirmaDal(SqlBaglantisi x)
        {
            baglanti = x;
        }

        public Firma Add(Firma entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Firma(AD,YETKILITC,SEKTOR,YETKILISTATU,YETKILIADSOYAD,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,ADRES,VERGIDAIRE,OZELKOD1,OZELKOD2,OZELKOD3) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", baglanti.BaglantiDondur());

                komut.Parameters.AddWithValue("@p1", entity.AD);
                komut.Parameters.AddWithValue("@p2", entity.YETKILITC);
                komut.Parameters.AddWithValue("@p3", entity.SEKTOR);
                komut.Parameters.AddWithValue("@p4", entity.YETKILISTATU);
                komut.Parameters.AddWithValue("@p5", entity.YETKILIADSOYAD);
                komut.Parameters.AddWithValue("@p6", entity.TELEFON1);
                komut.Parameters.AddWithValue("@p7", entity.TELEFON2);
                komut.Parameters.AddWithValue("@p8", entity.TELEFON3);
                komut.Parameters.AddWithValue("@p9", entity.MAIL);
                komut.Parameters.AddWithValue("@p10", entity.FAX);
                komut.Parameters.AddWithValue("@p11", entity.IL);
                komut.Parameters.AddWithValue("@p12", entity.ILCE);
                komut.Parameters.AddWithValue("@p13", entity.ADRES);
                komut.Parameters.AddWithValue("@p14", entity.VERGIDAIRE);
                komut.Parameters.AddWithValue("@p15", entity.OZELKOD1);
                komut.Parameters.AddWithValue("@p16", entity.OZELKOD2);
                komut.Parameters.AddWithValue("@p17", entity.OZELKOD3);

                komut.ExecuteNonQuery();

                baglanti.BaglantiDondur().Close();

                return entity;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Firma Delete(Firma entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Delete from Tbl_Firma where ID=@p1", baglanti.BaglantiDondur());
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

        public Firma Get(Firma entity)
        {
            throw new NotImplementedException();
        }

        public DataTable List()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Tbl_Firma", baglanti.BaglantiDondur());
            adapter.Fill(table);
            return table;
        }

        public DataTable ListForBankalarForm()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select ID,AD from Tbl_Firma", baglanti.BaglantiDondur());
            adapter.Fill(table);
            baglanti.BaglantiDondur().Close();

            return table;
        }

        public Dictionary<string, decimal> ListForStoklarChart2()
        {
            Dictionary<string, decimal> veriler = new Dictionary<string, decimal>();
            SqlCommand komut = new SqlCommand("select IL,count(*) from Tbl_Firma group by IL", baglanti.BaglantiDondur());
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                veriler.Add(okuyucu[0].ToString(), decimal.Parse(okuyucu[1].ToString()));
            }
            baglanti.BaglantiDondur().Close();
            return veriler;
        }

        public Firma Update(Firma entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Tbl_Firma set AD=@p1,YETKILITC=@p2,SEKTOR=@p3,YETKILISTATU=@p4,YETKILIADSOYAD=@p5,TELEFON1=@p6,TELEFON2=@p7,TELEFON3=@p8,MAIL=@p9,FAX=@p10,IL=@p11,ILCE=@p12,ADRES=@p13,VERGIDAIRE=@p14,OZELKOD1=@p15,OZELKOD2=@p16,OZELKOD3=@p17 where ID=@p18", baglanti.BaglantiDondur());

                komut.Parameters.AddWithValue("@p1", entity.AD);
                komut.Parameters.AddWithValue("@p2", entity.YETKILITC);
                komut.Parameters.AddWithValue("@p3", entity.SEKTOR);
                komut.Parameters.AddWithValue("@p4", entity.YETKILISTATU);
                komut.Parameters.AddWithValue("@p5", entity.YETKILIADSOYAD);
                komut.Parameters.AddWithValue("@p6", entity.TELEFON1);
                komut.Parameters.AddWithValue("@p7", entity.TELEFON2);
                komut.Parameters.AddWithValue("@p8", entity.TELEFON3);
                komut.Parameters.AddWithValue("@p9", entity.MAIL);
                komut.Parameters.AddWithValue("@p10", entity.FAX);
                komut.Parameters.AddWithValue("@p11", entity.IL);
                komut.Parameters.AddWithValue("@p12", entity.ILCE);
                komut.Parameters.AddWithValue("@p13", entity.ADRES);
                komut.Parameters.AddWithValue("@p14", entity.VERGIDAIRE);
                komut.Parameters.AddWithValue("@p15", entity.OZELKOD1);
                komut.Parameters.AddWithValue("@p16", entity.OZELKOD2);
                komut.Parameters.AddWithValue("@p17", entity.OZELKOD3);
                komut.Parameters.AddWithValue("@p17", entity.ID);

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
