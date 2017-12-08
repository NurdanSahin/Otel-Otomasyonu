using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace OtelOtomasyonu.ORM
{
    public class Tools
    {
        //SingleTon PATTERN
        private static SqlConnection baglanti;

        public static SqlConnection Baglanti
        {
            get {
                if (baglanti == null)
                    baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
                return baglanti;
            }
            
        }
       public static bool Exec(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();

                int etk = cmd.ExecuteNonQuery();
                return etk > 0 ? true : false;
         
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
        }
        public static object ExecScalar(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                 cmd.Connection.Open();
                object deger= cmd.ExecuteScalar();
                return deger;
            }
            catch (Exception)
            {

                return 0;
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                    cmd.Connection.Close();
            }
        }
      public static void ParametreOlustur<T>(SqlCommand cmd,KomutTip kt,T ent)
        {
            PropertyInfo[] propertys = typeof(T).GetProperties();

            foreach (PropertyInfo pi in propertys)
            {
                string name = pi.Name;
                if (name.ToLower() == "ıd" || name.ToLower() == "id" && kt == KomutTip.Insert)
                {
                    continue; ;
                }
                else if (kt == KomutTip.Delete &&(name.ToLower() != "id" || name.ToLower() != "ıd")){ 
                continue;
            }
                object value = pi.GetValue(ent);
                cmd.Parameters.AddWithValue("@" + name, value);
            }

        }

    }
}
