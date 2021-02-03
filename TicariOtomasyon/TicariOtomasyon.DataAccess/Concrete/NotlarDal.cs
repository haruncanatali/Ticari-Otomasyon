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
    public class NotlarDal : INotlarDal
    {

        SqlBaglantisi baglanti;

        public NotlarDal()
        {
            baglanti = new SqlBaglantisi();
        }

        public Notlar Add(Notlar entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Notlar(TARIH,SAAT,BASLIK,DETAY,OLUSTURAN,HITAP) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti.BaglantiDondur());

                komut.Parameters.AddWithValue("@p1", entity.TARIH);
                komut.Parameters.AddWithValue("@p2", entity.SAAT);
                komut.Parameters.AddWithValue("@p3", entity.BASLIK);
                komut.Parameters.AddWithValue("@p4", entity.DETAY);
                komut.Parameters.AddWithValue("@p5", entity.OLUSTURAN);
                komut.Parameters.AddWithValue("@p6", entity.HITAP);

                komut.ExecuteNonQuery();
                baglanti.BaglantiDondur().Close();

                return entity;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Notlar Delete(Notlar entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("delete from Tbl_Notlar where ID=@p1", baglanti.BaglantiDondur());

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

        public Notlar Get(Notlar entity)
        {
            throw new NotImplementedException();
        }

        public DataTable List()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Tbl_Notlar", baglanti.BaglantiDondur());
            adapter.Fill(table);
            baglanti.BaglantiDondur().Close();

            return table;

        }

        public Notlar Update(Notlar entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Tbl_Notlar set TARIH=@p1,SAAT=@p2,BASLIK=@p3,DETAY=@p4,OLUSTURAN=@p5,HITAP=@p6 where ID=@p7", baglanti.BaglantiDondur());

                komut.Parameters.AddWithValue("@p1", entity.TARIH);
                komut.Parameters.AddWithValue("@p2", entity.SAAT);
                komut.Parameters.AddWithValue("@p3", entity.BASLIK);
                komut.Parameters.AddWithValue("@p4", entity.DETAY);
                komut.Parameters.AddWithValue("@p5", entity.OLUSTURAN);
                komut.Parameters.AddWithValue("@p6", entity.HITAP);
                komut.Parameters.AddWithValue("@p7", entity.ID);


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
