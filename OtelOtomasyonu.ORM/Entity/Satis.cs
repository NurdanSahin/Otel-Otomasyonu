using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM.Entity
{
    public class Satis
    {
        public int Id { get; set; }
        public int MusteriID { get; set; }
        public int PersonelID { get; set; }
        public int OdaID { get; set; }
        public DateTime SatisTarihi { get; set; }
        public decimal OdaFiyati { get; set; }

    }
}
