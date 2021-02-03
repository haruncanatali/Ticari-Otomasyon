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
    public class OzelKodManager : IOzelKodService
    {
        IOzelKodDal _dal;

        public OzelKodManager(IOzelKodDal x)
        {
            _dal = x;
        }

        public OzelKod Get()
        {
            return _dal.Get();
        }
    }
}
