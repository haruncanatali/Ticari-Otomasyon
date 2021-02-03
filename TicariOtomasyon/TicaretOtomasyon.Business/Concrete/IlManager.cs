using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Business.Abstract;
using TicaretOtomasyonu.Entities.Concrete;
using TicariOtomasyon.DataAccess.Abstract;

namespace TicaretOtomasyonu.Business.Concrete
{
    public class IlManager : IIlService
    {

        IIlDal _dal;
        public IlManager(IIlDal x)
        {
            _dal = x;
        }

        public List<Il> List()
        {
            return _dal.List();
        }
    }
}
