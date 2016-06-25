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
    public class PedidoDAO: BaseDAO<Pedido,int> 
    { 
    }
    /*public class PedidoDAO
    {
        public static List<Pedido> Listar()
        {
            string str = "Server=(local); Database=DoDesign; Integrated Security=true";
            List<Pedido> listado = new List<Pedido>();
            using (SqlConnection cn = new SqlConnection(str))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from Pedido", cn);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr != null && sdr.HasRows)
                {
                    Pedido pedido;
                    while (sdr.Read())
                    {
                        pedido = new Pedido();
                        pedido.IdPedido = int.Parse(sdr["IdPedido"].ToString());
                        pedido.Polo.IdPolo = int.Parse(sdr["IdPolo"].ToString());
                        pedido.Pago.IdPago = int.Parse(sdr["IdPago"].ToString());
                        pedido.Cliente.NombreUsuario= sdr["NombreUsuario"].ToString();
                        pedido.NroTargeta = sdr["NroTargeta"].ToString();
                        listado.Add(pedido);
                    }
                }
            }
            return listado;
        }

        public static bool Crear(Pedido pedido)
        {
            bool agregado = false;
            string str = "Server=(local); Database=DoDesign; Integrated Security=true";
            
            using (SqlConnection cn = new SqlConnection(str))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into Pedido values(@pr1,@pr2,@pr3,@pr4)", cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@pr1", pedido.Polo.IdPolo);
                cmd.Parameters.AddWithValue("@pr2", pedido.Pago.IdPago);
                cmd.Parameters.AddWithValue("@pr3", pedido.Cliente.NombreUsuario);
                cmd.Parameters.AddWithValue("@pr4", pedido.NroTargeta);
                agregado = cmd.ExecuteNonQuery() > 0;
            }
            return agregado;
        }

        public static bool Eliminar(int IdPedido)
        {
            bool Eliminado = false;
            string str = "Server=(local); Database=DoDesign; Integrated Security=true";

            using (SqlConnection cn = new SqlConnection(str))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("delete from Pedido where IdPedido=@pr1)", cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@pr1", IdPedido);
                Eliminado = cmd.ExecuteNonQuery() > 0;
            }
            return Eliminado;
        }
    }*/
}