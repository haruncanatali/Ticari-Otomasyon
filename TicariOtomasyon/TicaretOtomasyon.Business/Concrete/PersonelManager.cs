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
    public class PersonelManager : IPersonelService
    {

        IPersonelDal dal;
        public PersonelManager(IPersonelDal x)
        {
            dal = x;
        }

        public Personel Add(Personel entity)
        {
            return dal.Add(entity);
        }

        public Personel Delete(Personel entity)
        {
            return dal.Delete(entity);
        }

        public Personel Get(Personel entity)
        {
            return dal.Get(entity);
        }

        public DataTable List()
        {
            return dal.List();
        }

        public Personel Update(Personel entity)
        {
            return dal.Update(entity);
        }
    }
}
