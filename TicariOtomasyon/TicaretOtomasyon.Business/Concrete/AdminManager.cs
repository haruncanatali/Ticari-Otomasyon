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
    public class AdminManager : IAdminService
    {

        IAdminDal _dal;

        public AdminManager(IAdminDal x)
        {
            _dal = x;   
        }

        public Admin Add(Admin admin)
        {
            return _dal.Add(admin);
        }

        public Admin Delete(Admin admin)
        {
            return _dal.Delete(admin);
        }

        public Admin Get(Admin admin)
        {
            return _dal.Get(admin);
        }

        public DataTable List()
        {
            return _dal.List();
        }

        public Admin Update(Admin admin)
        {
            return _dal.Update(admin);
        }
    }
}
