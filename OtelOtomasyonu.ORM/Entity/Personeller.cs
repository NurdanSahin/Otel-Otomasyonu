using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM.Entity
{
    public class Personeller
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Tckn { get; set; }
        public string TelNo { get; set; }
        public string Adres { get; set; }
        public DateTime DogumTarihi { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public decimal Maas { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }

        public bool Aktif { get; set; }

    }
}
