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
    public class NotlarManager : INotlarService
    {

        INotlarDal dal;
        public NotlarManager(INotlarDal x)
        {
            dal = x;
        }

        public Notlar Add(Notlar entity)
        {
            return dal.Add(entity);
        }

        public Notlar Delete(Notlar entity)
        {
            return dal.Delete(entity);
        }

        public Notlar Get(Notlar entity)
        {
            return dal.Get(entity);
        }

        public DataTable List()
        {
            return dal.List();
        }

        public Notlar Update(Notlar entity)
        {
            return dal.Update(entity);
        }
    }
}
