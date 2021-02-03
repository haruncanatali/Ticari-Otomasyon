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
    public class FirmaManager : IFirmaService
    {

        IFirmaDal _dal;

        public FirmaManager(IFirmaDal x)
        {
            _dal = x;
        }

        public Firma Add(Firma entity)
        {
            return _dal.Add(entity);
        }

        public Firma Delete(Firma entity)
        {
            return _dal.Delete(entity);
        }

        public Firma Get(Firma entity)
        {
            return _dal.Get(entity);
        }

        public DataTable List()
        {
            return _dal.List();
        }

        public DataTable ListForBankalarForm()
        {
            return _dal.ListForBankalarForm();
        }

        public Dictionary<string, decimal> ListForStoklarChart2()
        {
            return _dal.ListForStoklarChart2();
        }

        public Firma Update(Firma entity)
        {
            return _dal.Update(entity);
        }
    }
}
