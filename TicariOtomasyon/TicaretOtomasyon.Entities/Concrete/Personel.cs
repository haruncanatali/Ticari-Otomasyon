using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Entities.Abstract;

namespace TicaretOtomasyonu.Entities.Concrete
{
    public class Personel:IEntity
    {
        public int ID { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public string TELEFON { get; set; }
        public string TC { get; set; }
        public string MAIL { get; set; }
        public string IL { get; set; }
        public string ILCE { get; set; }
        public string ADRES { get; set; }
        public string GOREV { get; set; }

    }
}
