using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM.Entity
{
    public class SatisDetay
    {
        public int SatisID { get; set; }
        public int UrunID { get; set; }
        public double Miktar { get; set; }
        public decimal Fiyat { get; set; }
        public double Indirim { get; set; }

    }
}
