using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Entities.Abstract;

namespace TicaretOtomasyonu.Entities.Concrete
{
    public class Gider:IEntity
    {
        public int ID { get; set; }
        public string AY { get; set; }
        public string YIL { get; set; }
        public decimal ELEKTRIK { get; set; }
        public decimal DOGALGAZ { get; set; }
        public decimal SU { get; set; }
        public decimal INTERNET { get; set; }
        public decimal MAASLAR { get; set; }
        public decimal EKSTRA { get; set; }
        public string NOTLAR { get; set; }
    }
}
