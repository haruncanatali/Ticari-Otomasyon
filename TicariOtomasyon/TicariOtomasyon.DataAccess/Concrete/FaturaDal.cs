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
    public class FaturaDal : IFaturaDal
    {

        SqlBaglantisi baglanti;

        public FaturaDal(SqlBaglantisi x)
        {
            baglanti = x;
        }

        public Fatura Add(Fatura entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_FaturaBilgi(SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti.BaglantiDondur());

                komut.Parameters.AddWithValue("@p1", entity.SERI);
                komut.Parameters.AddWithValue("@p2", entity.SIRANO);
                komut.Parameters.AddWithValue("@p3", entity.TARIH);
                komut.Parameters.AddWithValue("@p4", entity.SAAT);
                komut.Parameters.AddWithValue("@p5", entity.VERGIDAIRE);
                komut.Parameters.AddWithValue("@p6", entity.ALICI);
                komut.Parameters.AddWithValue("@p7", entity.TESLIMEDEN);
                komut.Parameters.AddWithValue("@p8", entity.TESLIMALAN);

                komut.ExecuteNonQuery();
                baglanti.BaglantiDondur().Close();

                return entity;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Fatura Delete(Fatura entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("delete from Tbl_FaturaBilgi where ID=@p1", baglanti.BaglantiDondur());
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

        public Fatura Get(Fatura entity)
        {
            throw new NotImplementedException();
        }

        public DataTable List()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Tbl_FaturaBilgi", baglanti.BaglantiDondur());
            adapter.Fill(table);
            baglanti.BaglantiDondur().Close();
            return table;
        }

        public Fatura Update(Fatura entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Tbl_FaturaBilgi set SERI=@p1,SIRANO=@p2,TARIH=@p3,SAAT=@p4,VERGIDAIRE=@p5,ALICI=@p6,TESLIMEDEN=@p7,TESLIMALAN=@p8 where ID=@p9", baglanti.BaglantiDondur());

                komut.Parameters.AddWithValue("@p1", entity.SERI);
                komut.Parameters.AddWithValue("@p2", entity.SIRANO);
                komut.Parameters.AddWithValue("@p3", entity.TARIH);
                komut.Parameters.AddWithValue("@p4", entity.SAAT);
                komut.Parameters.AddWithValue("@p5", entity.VERGIDAIRE);
                komut.Parameters.AddWithValue("@p6", entity.ALICI);
                komut.Parameters.AddWithValue("@p7", entity.TESLIMEDEN);
                komut.Parameters.AddWithValue("@p8", entity.TESLIMALAN);
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
