using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Entities.Abstract;

namespace TicaretOtomasyonu.Entities.Concrete
{
    public class Fatura:IEntity
    {
        public int ID { get; set; }
        public string SERI { get; set; }
        public string SIRANO { get; set; }
        public DateTime TARIH { get; set; }
        public string SAAT { get; set; }
        public string VERGIDAIRE { get; set; }
        public string ALICI { get; set; }
        public string TESLIMEDEN { get; set; }
        public string TESLIMALAN { get; set; }
    }
}
