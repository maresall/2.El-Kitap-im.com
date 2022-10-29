using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ApiNG.Controllers
{
    public class SatisYapanlarController : ApiController
    {
        Entities _ent = new Entities();

    }
    public class SatisYapanTip {
        public int SatisIYapanID { get; set; }
        public int KullaniciID { get; set; }
        public int KitapID { get; set; }
        public System.DateTime Tarih { get; set; }
    }
}