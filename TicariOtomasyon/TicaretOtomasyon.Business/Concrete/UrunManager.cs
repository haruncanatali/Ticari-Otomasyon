using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Business.Abstract;
using TicaretOtomasyonu.Entities.Concrete;
using TicariOtomasyon.DataAccess.Abstract;

namespace TicaretOtomasyonu.Business.Concrete
{
    public class UrunManager : IUrunService
    {
        IUrunDal dal;

        public UrunManager(IUrunDal x)
        {
            dal = x;
        }

        public Urun Add(Urun entity)
        {
            return dal.Add(entity);
        }

        public Urun Delete(Urun entity)
        {
            return dal.Delete(entity);
        }

        public Urun Get(Urun entity)
        {
            return dal.Get(entity);
        }

        public DataTable List()
        {
            return dal.List();
        }

        public DataTable ListForStoklarBind()
        {
            return dal.ListForStoklarBind();
        }

        public Dictionary<string,decimal> ListForStoklarChart1()
        {
            return dal.ListForStoklarChart1();
        }

        public Urun Update(Urun entity)
        {
            return dal.Update(entity);
        }
    }
}
