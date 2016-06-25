using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using BigStore.DoDesignWS.Model;
using BigStore.DoDesignWS.Persistencia;

namespace BigStore.DoDesignWS.Data
{
    public class PoloDAO: BaseDAO<Polo,int>
    {
    }
    /*public class PoloDAO
    {
        public static bool ConsultarPolo(int IdPolo)
        {
            bool exito = false;
            string str = "Server=(local); Database=DoDesign; Integrated Security=true";
            using (SqlConnection cn = new SqlConnection(str))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select Count(IdPolo) from Polo where IdPolo=@pr1", cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@pr1", IdPolo);
                int cantidad = int.Parse(cmd.ExecuteScalar().ToString());
                exito = cantidad > 0;
            }
            return exito;
        }
    }*/
}