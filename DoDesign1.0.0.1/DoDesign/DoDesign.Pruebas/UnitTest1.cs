using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DoDesign.Pruebas.TransaccionWS;
using System.Collections.Generic;

namespace DoDesign.Pruebas
{
   [TestClass]
    public class UnitTest1
    {
        /*  TransaccionClient proxy = new TransaccionClient();

         [TestMethod]
         public void ListarPedido()
         {
             try
             {
                 var proxy = new TransaccionClient();
                 IList<Pedido> Listado = proxy.ListarPedido();

                 Assert.AreNotEqual(null, Listado);
                 Assert.IsTrue(Listado.Count > 0);
             }
             catch (Exception)
             {
             }
         }
         [TestMethod]
         public void ObtenerCliente()
         {
             try
             {
                 var proxy = new TransaccionClient();
                 Cliente cliente = new Cliente();
                 cliente = proxy.ObtenerCliente(cliente.IdCliente);

                 Assert.AreNotEqual(null, cliente);
             }
             catch (Exception)
             {
             }
         }

     */


        [TestMethod]
        public void CrearPedido()
        {
                Polo polo = new Polo();
                Pago pago = new Pago();
                Cliente cliente = new Cliente();
                polo.IdPolo = 1;
                pago.IdPago = 1;
                cliente.IdCliente = 2;
                Pedido pedido = new Pedido()
                {
                    Polo = polo,
                    Pago = pago,
                    Cliente=cliente,
                    NroTargeta="9556554584"
                };
                TransaccionClient proxy = new TransaccionClient();
                proxy.CrearPedido(pedido);
                Assert.AreNotEqual(null, pedido);
            
        }
    }
}
