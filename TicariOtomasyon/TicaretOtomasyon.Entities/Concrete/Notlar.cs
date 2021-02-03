using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Entities.Abstract;

namespace TicaretOtomasyonu.Entities.Concrete
{
    public class Notlar:IEntity
    {
        public int ID { get; set; }
        public DateTime TARIH { get; set; }
        public string SAAT { get; set; }
        public string BASLIK { get; set; }
        public string DETAY { get; set; }
        public string OLUSTURAN { get; set; }
        public string HITAP { get; set; }
    }
}
