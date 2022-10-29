using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ApiNG.Controllers
{
    public class SatınAlanlarController : ApiController
    {
        Entities _ent = new Entities();
    }
    public class SatınAlanTip
    {
        public int SatinAlanID { get; set; }
        public int KullaniciID { get; set; }
        public int KitapID { get; set; }
        public System.DateTime Tarih { get; set; }
    }
}