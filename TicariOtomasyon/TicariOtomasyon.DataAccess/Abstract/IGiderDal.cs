using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Entities.Concrete;

namespace TicariOtomasyon.DataAccess.Abstract
{
    public interface IGiderDal:IEntityRepository<Gider>
    {
        Dictionary<string,decimal> ListForGiderlerFormChart1();
    }
}
