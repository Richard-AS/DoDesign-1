using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigStore.DoDesignWS.Model
{
    public class DetallePedido
    {
        public int IdDetallePedido{ get; set; }
        public Pedido Pedido { get; set; }
        public int Cantidad { get; set; }
        public double Costo { get; set; }
    }
}