using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu.ORM
{
    public class ORMBase<T> : IORM<T> where T : class 
    {
        private string ClassName
        {
            get
            {
               return typeof(T).Name;
            }
        }
        public bool Delete(T entity)
        {
           SqlCommand cmd=new SqlCommand(string.Format("prc_{0}_Delete",ClassName),Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            Tools.ParametreOlustur<T>(cmd, KomutTip.Delete, entity);
            return Tools.Exec(cmd);
        }

        public bool Insert(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Insert",ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            Tools.ParametreOlustur<T>(cmd, KomutTip.Insert, entity);
           return Tools.Exec(cmd);
        }

        public object InsertScalar(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Insert", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            Tools.ParametreOlustur<T>(cmd, KomutTip.Insert, entity);
            return Tools.ExecScalar(cmd);
        }

        public DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter(string.Format("prc_{0}_Select", ClassName), Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;

        }

        public bool Update(T entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("prc_{0}_Update", ClassName), Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            Tools.ParametreOlustur<T>(cmd, KomutTip.Update, entity);
           return Tools.Exec(cmd);
        }
    }
}
