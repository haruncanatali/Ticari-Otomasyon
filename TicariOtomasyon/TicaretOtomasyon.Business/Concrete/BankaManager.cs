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
    public class BankaManager : IBankaService
    {
        IBankaDal _dal;
        public BankaManager(IBankaDal x)
        {
            _dal = x;
        }

        public Banka Add(Banka entity)
        {
            return _dal.Add(entity);
        }

        public Banka Delete(Banka entity)
        {
            return _dal.Delete(entity);
        }

        public Banka Get(Banka entity)
        {
            return _dal.Get(entity);
        }

        public DataTable List()
        {
            return _dal.List();
        }

        public Banka Update(Banka entity)
        {
            return _dal.Update(entity);
        }
    }
}
