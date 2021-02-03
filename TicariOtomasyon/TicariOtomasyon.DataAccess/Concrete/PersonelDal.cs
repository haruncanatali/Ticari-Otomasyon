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
    public class PersonelDal : IPersonelDal
    {

        SqlBaglantisi baglanti;

        public PersonelDal(SqlBaglantisi x)
        {
            baglanti = x;
        }

        public Personel Add(Personel entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Personel(AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti.BaglantiDondur());

                komut.Parameters.AddWithValue("@p1", entity.AD);
                komut.Parameters.AddWithValue("@p2", entity.SOYAD);
                komut.Parameters.AddWithValue("@p3", entity.TELEFON);
                komut.Parameters.AddWithValue("@p4", entity.TC);
                komut.Parameters.AddWithValue("@p5", entity.MAIL);
                komut.Parameters.AddWithValue("@p6", entity.IL);
                komut.Parameters.AddWithValue("@p7", entity.ILCE);
                komut.Parameters.AddWithValue("@p8", entity.ADRES);
                komut.Parameters.AddWithValue("@p9", entity.GOREV);

                komut.ExecuteNonQuery();
                baglanti.BaglantiDondur().Close();

                return entity;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Personel Delete(Personel entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("delete from Tbl_Personel where ID=@p1", baglanti.BaglantiDondur());
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

        public Personel Get(Personel entity)
        {
            throw new NotImplementedException();
        }

        public DataTable List()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Tbl_Personel", baglanti.BaglantiDondur());
            adapter.Fill(table);
            baglanti.BaglantiDondur().Close();

            return table;
        }

        public Personel Update(Personel entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Tbl_Personel set AD=@p1,SOYAD=@p2,TELEFON=@p3,TC=@p4,MAIL=@p5,IL=@p6,ILCE=@p7,ADRES=@p8,GOREV=@p9 where ID=@p10", baglanti.BaglantiDondur());

                komut.Parameters.AddWithValue("@p1", entity.AD);
                komut.Parameters.AddWithValue("@p2", entity.SOYAD);
                komut.Parameters.AddWithValue("@p3", entity.TELEFON);
                komut.Parameters.AddWithValue("@p4", entity.TC);
                komut.Parameters.AddWithValue("@p5", entity.MAIL);
                komut.Parameters.AddWithValue("@p6", entity.IL);
                komut.Parameters.AddWithValue("@p7", entity.ILCE);
                komut.Parameters.AddWithValue("@p8", entity.ADRES);
                komut.Parameters.AddWithValue("@p9", entity.GOREV);
                komut.Parameters.AddWithValue("@p10",entity.ID);

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
