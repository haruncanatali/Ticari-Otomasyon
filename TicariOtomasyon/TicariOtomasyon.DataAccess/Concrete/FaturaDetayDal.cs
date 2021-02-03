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
    public class FaturaDetayDal : IFaturaDetayDal
    {
        SqlBaglantisi baglanti;

        public FaturaDetayDal(SqlBaglantisi x)
        {
            baglanti = x;
        }

        public FaturaDetay Add(FaturaDetay entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_FaturaDetay(URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values(@p1,@p2,@p3,@p4,@p5)", baglanti.BaglantiDondur());

                komut.Parameters.AddWithValue("@p1", entity.URUNAD);
                komut.Parameters.AddWithValue("@p2", entity.MIKTAR);
                komut.Parameters.AddWithValue("@p3", entity.FIYAT);
                komut.Parameters.AddWithValue("@p4", entity.TUTAR);
                komut.Parameters.AddWithValue("@p5", entity.FATURAID);

                komut.ExecuteNonQuery();
                baglanti.BaglantiDondur().Close();

                return entity;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public FaturaDetay Delete(FaturaDetay entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("delete from Tbl_FaturaDetay where ID=@p1", baglanti.BaglantiDondur());
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

        public FaturaDetay Get(FaturaDetay entity)
        {
            throw new NotImplementedException();
        }

        public DataTable List()
        {
            throw new NotImplementedException();
        }

        public DataTable ListForFaturalarForm(int id)
        {
            DataTable table = new DataTable();

            SqlCommand komut = new SqlCommand("select * from Tbl_FaturaDetay where FATURAID=@p1", baglanti.BaglantiDondur());
            komut.Parameters.AddWithValue("@p1", id);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = komut;
            adapter.Fill(table);
            baglanti.BaglantiDondur().Close();

            return table;
        }

        public FaturaDetay Update(FaturaDetay entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Tbl_FaturaDetay set URUNAD=@p1,MIKTAR=@p2,FIYAT=@p3,TUTAR=@p4,FATURAID=@p5 where ID=@p6", baglanti.BaglantiDondur());

                komut.Parameters.AddWithValue("@p1", entity.URUNAD);
                komut.Parameters.AddWithValue("@p2", entity.MIKTAR);
                komut.Parameters.AddWithValue("@p3", entity.FIYAT);
                komut.Parameters.AddWithValue("@p4", entity.TUTAR);
                komut.Parameters.AddWithValue("@p5", entity.FATURAID);
                komut.Parameters.AddWithValue("@p6", entity.ID);

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
