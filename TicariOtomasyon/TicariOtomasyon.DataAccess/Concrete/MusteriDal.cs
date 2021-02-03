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
    public class MusteriDal : IMusteriDal
    {
        SqlBaglantisi baglanti;

        public MusteriDal()
        {
            baglanti = new SqlBaglantisi();
        }


        public Musteri Add(Musteri entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Musteri(AD,SOYAD,TELEFON1,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRE) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti.BaglantiDondur());


                komut.Parameters.AddWithValue("@p1", entity.AD);
                komut.Parameters.AddWithValue("@p2", entity.SOYAD);
                komut.Parameters.AddWithValue("@p3", entity.TELEFON1);
                komut.Parameters.AddWithValue("@p4", entity.TELEFON2);
                komut.Parameters.AddWithValue("@p5", entity.TC);
                komut.Parameters.AddWithValue("@p6", entity.MAIL);
                komut.Parameters.AddWithValue("@p7", entity.IL);
                komut.Parameters.AddWithValue("@p8", entity.ILCE);
                komut.Parameters.AddWithValue("@p9", entity.ADRES);
                komut.Parameters.AddWithValue("@p10", entity.VERGIDAIRE);

                komut.ExecuteNonQuery();

                baglanti.BaglantiDondur().Close();

                return entity;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Musteri Delete(Musteri entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("delete from Tbl_Musteri where ID=@p1", baglanti.BaglantiDondur());
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

        public Musteri Get(Musteri entity)
        {
            throw new NotImplementedException();
        }

        public DataTable List()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Tbl_Musteri", baglanti.BaglantiDondur());
            adapter.Fill(table);
            baglanti.BaglantiDondur().Close();

            return table;
        }

        public DataTable ListForAnasayfa()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select AD,SOYAD,TELEFON1,TELEFON2 from Tbl_Musteri", baglanti.BaglantiDondur());
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            baglanti.BaglantiDondur().Close();

            return tbl;
        }

        public Musteri Update(Musteri entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Tbl_Musteri set AD=@p1,SOYAD=@p2,TELEFON1=@p3,TELEFON2=@p4,TC=@p5,MAIL=@p6,IL=@p7,ILCE=@p8,ADRES=@p9,VERGIDAIRE=@p10 where ID=@p11", baglanti.BaglantiDondur());


                komut.Parameters.AddWithValue("@p1", entity.AD);
                komut.Parameters.AddWithValue("@p2", entity.SOYAD);
                komut.Parameters.AddWithValue("@p3", entity.TELEFON1);
                komut.Parameters.AddWithValue("@p4", entity.TELEFON2);
                komut.Parameters.AddWithValue("@p5", entity.TC);
                komut.Parameters.AddWithValue("@p6", entity.MAIL);
                komut.Parameters.AddWithValue("@p7", entity.IL);
                komut.Parameters.AddWithValue("@p8", entity.ILCE);
                komut.Parameters.AddWithValue("@p9", entity.ADRES);
                komut.Parameters.AddWithValue("@p10", entity.VERGIDAIRE);
                komut.Parameters.AddWithValue("@p11", entity.ID);


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
