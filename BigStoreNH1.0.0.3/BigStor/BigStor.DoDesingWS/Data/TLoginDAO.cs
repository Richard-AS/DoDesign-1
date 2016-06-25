
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
    public class TLoginDAO: BaseDAO<TLogin,int>
    {
    }

    /* public class TLoginDAO
    {
        public byte Error { get; set; }
         public string Mensaje { get; set; }

         public static bool LoginCli(string NombreUsuario, string Contrasenia)
         {
             bool logueado = false;
             string str = "Server=(local); Database=Dodesign; Integrated Security=true";
             TLogin login = new TLogin();
             using (SqlConnection cn = new SqlConnection(str))
             {
                 cn.Open();
                 SqlCommand cmd = new SqlCommand("spLogin"+" @NombreUsuario ,@Contrasenia", cn);
                 cmd.CommandType = CommandType.Text;
                 cmd.Parameters.AddWithValue("@NombreUsuario", login.NombreUsuario);
                 cmd.Parameters.AddWithValue("@Contrasenia", login.Contrasenia);
                 logueado = cmd.ExecuteNonQuery() > 0;
             }
             return logueado;
         }
    }*/
}