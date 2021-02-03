using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Entities.Abstract;

namespace TicaretOtomasyonu.Entities.Concrete
{
    public class FaturaDetay:IEntity
    {
        public int ID { get; set; }
        public string URUNAD { get; set; }
        public int MIKTAR { get; set; }
        public decimal FIYAT { get; set; }
        public decimal TUTAR { get; set; }
        public int FATURAID { get; set; }
    }
}
