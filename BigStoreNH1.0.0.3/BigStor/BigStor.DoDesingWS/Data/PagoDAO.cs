using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BigStore.DoDesignWS.Model;
using BigStore.DoDesignWS.Persistencia;
namespace BigStore.DoDesignWS.Data
{
    public class PagoDAO : BaseDAO<Pago, int> 
    {
    } 

    /*public class PagoDAO
    {
        public static bool ConsultarPago(int  IdPago)
        {
            bool exito = false;
            string str = "Server=(local); Database=DoDesign; Integrated Security=true";
            using (SqlConnection cn = new SqlConnection(str))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select Count(IdPago) from Pago where IdPago=@pr1", cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@pr1", IdPago);
                int cantidad = int.Parse(cmd.ExecuteScalar().ToString());
                exito = cantidad > 0;
            }
            return exito;
        }
    }*/
}