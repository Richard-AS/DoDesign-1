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

    public class ClienteDAO : BaseDAO<Cliente, int> 
    {
    }
    /*public class ClienteDAO
    {
        public static Cliente ConsultarCliente(string NombreUsuario)
        {
            Cliente cliente = new Cliente();
            string str = "Server=(local); Database=DoDesign; Integrated Security=true";
            using (SqlConnection cn = new SqlConnection(str))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from Cliente where NombreUsuario=@pr1", cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@pr1",NombreUsuario);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr != null && sdr.HasRows)
                {
                    Cliente cli;
                    while (sdr.Read())
                    {
                        cli = new Cliente();
                        cli.NombreUsuario = sdr["NombreUsuario"].ToString();
                        cli.Nombre = sdr["Nombre"].ToString();
                        cli.Apellido = sdr["Apellido"].ToString();
                        cli.Telefono = sdr["Telefono"].ToString();
                        cli.Direccion = sdr["Direccion"].ToString();
                        cli.FechaNacimiento = DateTime.Parse(sdr["FechaNacimiento"].ToString());
                        cli.DNI = sdr["DNI"].ToString();
                        cli.NroTargeta = sdr["NroTargeta"].ToString();
                        cliente = cli;
                    }
                }

            }
            return cliente;
        }
    }*/
}