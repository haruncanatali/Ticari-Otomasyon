using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretOtomasyonu.Entities.Abstract;

namespace TicaretOtomasyonu.Entities.Concrete
{
    public class Admin:IEntity
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Userkey { get; set; }
    }
}
