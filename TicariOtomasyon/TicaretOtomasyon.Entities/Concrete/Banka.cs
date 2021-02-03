using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Entities.Abstract;

namespace TicaretOtomasyonu.Entities.Concrete
{
    public class Banka:IEntity
    {
        public int ID { get; set; }
        public string BANKAADI { get; set; }
        public string IL { get; set; }
        public string ILCE { get; set; }
        public string SUBE { get; set; }
        public string TELEFON { get; set; }
        public string IBAN { get; set; }
        public string HESAPNO { get; set; }
        public string YETKILI{ get; set; }
        public DateTime TARIH { get; set; }
        public string HESAPTURU { get; set; }
        public int FIRMAID { get; set; }
    }
}
