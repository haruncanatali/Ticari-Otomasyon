using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Entities.Abstract;

namespace TicaretOtomasyonu.Entities.Concrete
{
    public class Il:IEntity
    {
        public int ID { get; set; }
        public string SEHIR { get; set; }
    }
}
