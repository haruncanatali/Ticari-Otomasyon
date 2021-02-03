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
    public class FaturaDetayManager : IFaturaDetayService
    {

        IFaturaDetayDal dal;
        public FaturaDetayManager(IFaturaDetayDal x)
        {
            dal = x;
        }

        public FaturaDetay Add(FaturaDetay entity)
        {
            return dal.Add(entity);
        }

        public FaturaDetay Delete(FaturaDetay entity)
        {
            return dal.Delete(entity);
        }

        public FaturaDetay Get(FaturaDetay entity)
        {
            return dal.Get(entity);
        }

        public DataTable List()
        {
            return dal.List();
        }

        public DataTable ListForFaturalarForm(int id)
        {
            return dal.ListForFaturalarForm(id);
        }

        public FaturaDetay Update(FaturaDetay entity)
        {
            return dal.Update(entity);
        }
    }
}
