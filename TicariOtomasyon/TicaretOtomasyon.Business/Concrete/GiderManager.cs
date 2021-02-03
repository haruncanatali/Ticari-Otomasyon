using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Business.Abstract;
using TicaretOtomasyonu.Entities.Concrete;
using TicariOtomasyon.DataAccess.Abstract;
using TicariOtomasyon.DataAccess.Concrete;

namespace TicaretOtomasyonu.Business.Concrete
{
    public class GiderManager : IGiderService
    {

        IGiderDal dal;

        public GiderManager(IGiderDal dx)
        {
            dal = dx;
        }

        public Gider Add(Gider entity)
        {
            return dal.Add(entity);
        }

        public Gider Delete(Gider entity)
        {
            return dal.Delete(entity);
        }

        public Gider Get(Gider entity)
        {
            return dal.Get(entity);
        }

        public DataTable List()
        {
            return dal.List();
        }

        public Dictionary<string, decimal> ListForGiderlerFormChart1()
        {
            return dal.ListForGiderlerFormChart1();
        }

        public Gider Update(Gider entity)
        {
            return dal.Update(entity);
        }
    }
}
