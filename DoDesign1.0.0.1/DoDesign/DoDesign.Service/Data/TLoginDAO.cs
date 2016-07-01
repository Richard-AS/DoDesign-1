
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DoDesign.Service.Dominio;
using DoDesign.Service.Persistencia;

namespace DoDesign.Service.Data
{
    public class TLoginDAO : BaseDAO<TLogin, int>
    {
        public byte Error { get; set; }
        public string Mensaje { get; set; }

        public static bool LoginCli(TLogin logueo)
        {
            bool logueado = false;
            string str = "Server=(local); Database=Dodesign; Integrated Security=true";
            TLogin login = new TLogin();
            using (SqlConnection cn = new SqlConnection(str))
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.Connection = cn;
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spLogin";
                if (logueo.NombreUsuario != null) 
                { 
                cmd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar, 50).Value = Convert.ToString(logueo.NombreUsuario);
                cmd.Parameters.Add("@Contrasenia", SqlDbType.VarChar, 50).Value = Convert.ToString(logueo.Contrasenia);
                }
                else if (logueo.Email != null)
                {
                cmd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar, 50).Value = Convert.ToString(logueo.Email);
                cmd.Parameters.Add("@Contrasenia", SqlDbType.VarChar, 50).Value = Convert.ToString(logueo.Contrasenia);
                }
                    logueado = cmd.ExecuteNonQuery() > 0;
            }
            return logueado;
        }
        public TLogin CrearLoginCli(TLogin logueo)
        {
            string str = "Server=(local); Database=Dodesign; Integrated Security=true";
            TLogin login = new TLogin();
            using (SqlConnection cn = new SqlConnection(str))
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spCrearLogin";
                    cmd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar, 50).Value = Convert.ToString(logueo.NombreUsuario);
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = Convert.ToString(logueo.Email);
                    cmd.Parameters.Add("@Contrasenia", SqlDbType.VarChar, 50).Value = Convert.ToString(logueo.Contrasenia);
                
                cmd.ExecuteNonQuery();
            }
            return logueo;
        }

        /*public static bool LoginCli(TLogin logueo)
        {
            bool logueado = false;
            string str = "Server=(local); Database=Dodesign; Integrated Security=true";
            TLogin login = new TLogin();
            using (SqlConnection cn = new SqlConnection(str))
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spLogin";
                cmd.Parameters.AddWithValue("@NombreUsuario", login.NombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasenia", login.Contrasenia);
                logueado = cmd.ExecuteNonQuery() > 0;
            }
            return logueado;
        }*/

    }

}   
