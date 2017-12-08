using OtelOtomasyonu.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM.Facade
{
     public class PersonellerORM :ORMBase <Personeller>
       
    {
        public static Personeller AktifKullanici;
        public Personeller GirisYap (Personeller p)
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_Personeller_Giris",Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            adp.SelectCommand.Parameters.AddWithValue("@ka", p.KullaniciAdi);
            adp.SelectCommand.Parameters.AddWithValue("@prl", p.Parola);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count == 0)
                return null;
            Personeller aktif = new Personeller();
            foreach (DataRow dr in dt.Rows) { 
                aktif.Id = (int)dr["Id"];
                aktif.Adi = dr["Adi"].ToString();
                aktif.Soyadi = dr["Soyadi"].ToString();
                aktif.KullaniciAdi = dr["KullaniciAdi"].ToString();
                aktif.Parola = dr["Parola"].ToString();
            }
            return aktif;
        }
    }
}
