using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Business.Abstract;
using TicaretOtomasyonu.Entities.Concrete;
using TicariOtomasyon.DataAccess.Abstract;
using TicariOtomasyon.DataAccess.Concrete;

namespace TicaretOtomasyonu.Business.Concrete
{
    public class IlceManager : IIlceService
    {
        IIlceDal _dal;

        public IlceManager(IIlceDal x)
        {
            _dal = x;
        }

        public List<Ilce> List(int id)
        {
            return _dal.List(id);
        }
    }
}
