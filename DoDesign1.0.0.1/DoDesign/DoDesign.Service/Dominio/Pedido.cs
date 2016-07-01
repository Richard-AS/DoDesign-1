using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace DoDesign.Service.Dominio
{
    
    public class Pedido
    {
        
        public int IdPedido { get; set; }
        
        public Polo IdPolo { get; set; }
        
        public Pago IdPago { get; set; }
        
        public Cliente IdCliente { get; set; }
        
        public string NroTarjeta { get; set; }
    }
}