using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Entities.Abstract;

namespace TicaretOtomasyonu.Entities.Concrete
{
    public class OzelKod:IEntity
    {
        public int ID { get; set; }
        public string FIRMAKOD1 { get; set; }
        public string FIRMAKOD2 { get; set; }
        public string FIRMAKOD3 { get; set; }
    }
}
