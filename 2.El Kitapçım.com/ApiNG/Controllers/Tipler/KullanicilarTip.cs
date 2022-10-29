using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiNG.Controllers.Tipler
{
    public class KullanicilarTip
    {
        public int KullaniciID { get; set; }
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public Nullable<System.DateTime> KayitTarihi { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string DogumTarihi { get; set; }
        public string TC { get; set; }
    }
}