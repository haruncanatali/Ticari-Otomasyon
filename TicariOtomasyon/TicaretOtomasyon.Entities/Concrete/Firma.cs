using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Entities.Abstract;

namespace TicaretOtomasyonu.Entities.Concrete
{
    public class Firma:IEntity
    {
        public int ID { get; set; }
        public string AD { get; set; }
        public string YETKILITC { get; set; }
        public string SEKTOR { get; set; }
        public string YETKILISTATU { get; set; }
        public string YETKILIADSOYAD { get; set; }
        public string TELEFON1 { get; set; }
        public string TELEFON2 { get; set; }
        public string TELEFON3 { get; set; }
        public string MAIL { get; set; }
        public string FAX { get; set; }
        public string IL { get; set; }
        public string ILCE { get; set; }
        public string ADRES { get; set; }
        public string VERGIDAIRE { get; set; }
        public string OZELKOD1 { get; set; }
        public string OZELKOD2 { get; set; }
        public string OZELKOD3 { get; set; }
    }
}
