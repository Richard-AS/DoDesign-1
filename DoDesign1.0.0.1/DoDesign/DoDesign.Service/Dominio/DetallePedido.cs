using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace DoDesign.Service.Dominio
{
    
    public class DetallePedido
    {
        
        public int IdDetallePedido{ get; set; }
        
        public Pedido IdPedido { get; set; }
        
        public int Cantidad { get; set; }
        
        public decimal Costo { get; set; }
    }
}