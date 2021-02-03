using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Entities.Abstract;

namespace TicaretOtomasyonu.Entities.Concrete
{
    public class Urun:IEntity
    {
        public int ID { get; set; }
        public string URUNAD { get; set; }
        public string URUNMARKA { get; set; }
        public string MODEL { get; set; }
        public string YIL { get; set; }
        public int ADET { get; set; }
        public decimal ALISFIYAT { get; set; }
        public decimal SATISFIYAT { get; set; }
        public string DETAY { get; set; }
    }
}
