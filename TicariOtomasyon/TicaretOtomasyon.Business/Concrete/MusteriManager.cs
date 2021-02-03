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
    public class MusteriManager : IMusteriService
    {

        IMusteriDal dal;
        public MusteriManager(IMusteriDal x)
        {
            dal = x;
        }

        public Musteri Add(Musteri entity)
        {
            return dal.Add(entity);
        }

        public Musteri Delete(Musteri entity)
        {
            return dal.Delete(entity);
        }

        public Musteri Get(Musteri entity)
        {
            return dal.Get(entity);
        }

        public DataTable List()
        {
            return dal.List();
        }

        public DataTable ListForAnasayfa()
        {
            return dal.ListForAnasayfa();
        }

        public Musteri Update(Musteri entity)
        {
            return dal.Update(entity);
        }
    }
}
