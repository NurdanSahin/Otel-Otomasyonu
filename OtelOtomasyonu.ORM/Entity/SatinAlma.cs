using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM.Entity
{
    public class SatinAlma
    {
        public int Id { get; set; }
        public int TedarikciID { get; set; }
        public DateTime SatinAlmaTarihi { get; set; }
        public int PersonelID { get; set; }
    }
}
