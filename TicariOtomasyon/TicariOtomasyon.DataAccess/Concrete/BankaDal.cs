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
    public class BankaDal : IBankaDal
    {
        SqlBaglantisi baglanti;

        public BankaDal()
        {
            baglanti = new SqlBaglantisi();
        }


        public Banka Add(Banka entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Banka(BANKAADI,IL,ILCE,SUBE,TELEFON,IBAN,HESAPNO,YETKILI,TARIH,HESAPTURU,FIRMAID) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglanti.BaglantiDondur());

                komut.Parameters.AddWithValue("@p1", entity.BANKAADI);
                komut.Parameters.AddWithValue("@p2", entity.IL);
                komut.Parameters.AddWithValue("@p3", entity.ILCE);
                komut.Parameters.AddWithValue("@p4", entity.SUBE);
                komut.Parameters.AddWithValue("@p5", entity.TELEFON);
                komut.Parameters.AddWithValue("@p6", entity.IBAN);
                komut.Parameters.AddWithValue("@p7", entity.HESAPNO);
                komut.Parameters.AddWithValue("@p8", entity.YETKILI);
                komut.Parameters.AddWithValue("@p9", entity.TARIH);
                komut.Parameters.AddWithValue("@p10", entity.HESAPTURU);
                komut.Parameters.AddWithValue("@p11", entity.FIRMAID);

                komut.ExecuteNonQuery();
                baglanti.BaglantiDondur().Close();

                return entity;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Banka Delete(Banka entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("delete from Tbl_Banka where ID=@p1", baglanti.BaglantiDondur());
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

        public Banka Get(Banka entity)
        {
            throw new NotImplementedException();
        }

        public DataTable List()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("exec BankaBilgileri", baglanti.BaglantiDondur());
            adapter.Fill(table);
            baglanti.BaglantiDondur().Close();
            return table;
        }

        public Banka Update(Banka entity)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Tbl_Banka set BANKAADI=@p1,IL=@p2,ILCE=@p3,SUBE=@p4,TELEFON=@p5,IBAN=@p6,HESAPNO=@p7,YETKILI=@p8,TARIH=@p9,HESAPTURU=@p10,FIRMAID=@p11 where ID=@p12", baglanti.BaglantiDondur());

                komut.Parameters.AddWithValue("@p1", entity.BANKAADI);
                komut.Parameters.AddWithValue("@p2", entity.IL);
                komut.Parameters.AddWithValue("@p3", entity.ILCE);
                komut.Parameters.AddWithValue("@p4", entity.SUBE);
                komut.Parameters.AddWithValue("@p5", entity.TELEFON);
                komut.Parameters.AddWithValue("@p6", entity.IBAN);
                komut.Parameters.AddWithValue("@p7", entity.HESAPNO);
                komut.Parameters.AddWithValue("@p8", entity.YETKILI);
                komut.Parameters.AddWithValue("@p9", entity.TARIH);
                komut.Parameters.AddWithValue("@p10", entity.HESAPTURU);
                komut.Parameters.AddWithValue("@p11", entity.FIRMAID);
                komut.Parameters.AddWithValue("@p12", entity.ID);

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
