using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ApiNG.Controllers
{
    public class ÜrünlerController : ApiController
    {
        Entities _ent = new Entities();
    }
    public class ÜrünTip {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdiSoyadi { get; set; }
        public short KitapSayfaSayisi { get; set; }
        public Nullable<System.DateTime> KitapBasimTarihi { get; set; }
        public string YayinEvi { get; set; }
        public double KitapFiyat { get; set; }
        public Nullable<short> KitapStok { get; set; }
        public string UrunTip { get; set; }
    }
}