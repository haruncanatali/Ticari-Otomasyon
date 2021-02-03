using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Entities.Concrete;

namespace TicaretOtomasyonu.Business.Abstract
{
    public interface IUrunService:IServiceRepository<Urun>
    {
        DataTable ListForStoklarBind();
        Dictionary<string,decimal> ListForStoklarChart1();
    }
}
