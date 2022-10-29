using ApiNG.Controllers.Tipler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ApiNG.Controllers
{
    public class KullanicilarController : ApiController
    {
        Entities _ent = new Entities();

        [HttpGet]
        public List<KullanicilarTip> TumKulanicilariGetir()
        {
            return _ent.Kullanicilar.Select(p=> new KullanicilarTip() { 
                AdSoyad = p.AdSoyad,
                Mail = p.Mail,
                Sifre = p.Sifre,
                KayitTarihi =p.KayitTarihi,
                Telefon = p.Telefon,
                Adres = p.Adres,
                DogumTarihi = p.DogumTarihi,
                TC = p.TC,
                KullaniciID = p.KullaniciID
            }).ToList();
        }
    }
}