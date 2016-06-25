using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigStore.DoDesignWS.Model
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public Polo Polo { get; set; }
        public Pago Pago { get; set; }
        public Cliente Cliente { get; set; }
        public string NroTargeta { get; set; }
    }
}