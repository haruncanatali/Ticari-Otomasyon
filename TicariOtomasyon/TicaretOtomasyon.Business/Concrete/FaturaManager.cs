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
    public class FaturaManager : IFaturaService
    {

        IFaturaDal _dal;

        public FaturaManager(IFaturaDal x)
        {
            _dal = x;
        }

        public Fatura Add(Fatura entity)
        {
            return _dal.Add(entity);
        }

        public Fatura Delete(Fatura entity)
        {
            return _dal.Delete(entity);
        }

        public Fatura Get(Fatura entity)
        {
            return _dal.Get(entity);
        }

        public DataTable List()
        {
            return _dal.List();
        }

        public Fatura Update(Fatura entity)
        {
            return _dal.Update(entity);
        }
    }
}
