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
    public class AdminDal : IAdminDal
    {
        SqlBaglantisi baglanti;
        public AdminDal()
        {
            baglanti = new SqlBaglantisi();
        }
        public Admin Add(Admin entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Admin(Username,Userkey) values(@p1,@p2)",baglanti.BaglantiDondur());

                komut.Parameters.AddWithValue("@p1", entity.Username);
                komut.Parameters.AddWithValue("@p2", entity.Userkey);

                komut.ExecuteNonQuery();

                baglanti.BaglantiDondur().Close();

                return entity;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public Admin Delete(Admin entity)
        {
            throw new NotImplementedException();
        }

        public Admin Get(Admin entity)
        {
            SqlCommand komut = new SqlCommand("select Username,Userkey from Tbl_Admin", baglanti.BaglantiDondur());
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                if (okuyucu[0].ToString() == entity.Username && okuyucu[1].ToString() == entity.Userkey)
                {
                    baglanti.BaglantiDondur().Close();
                    return entity;
                }
            }
            baglanti.BaglantiDondur().Close();

            return null;

        }
            
        public DataTable List()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Tbl_Admin", baglanti.BaglantiDondur());
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            baglanti.BaglantiDondur().Close();
            return tbl;
        }

        public Admin Update(Admin entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Tbl_Admin set Username=@p1,Userkey=@p2 where ID =@p3", baglanti.BaglantiDondur());

                komut.Parameters.AddWithValue("@p1", entity.Username);
                komut.Parameters.AddWithValue("@p2", entity.Userkey);
                komut.Parameters.AddWithValue("@p3", entity.ID);

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
