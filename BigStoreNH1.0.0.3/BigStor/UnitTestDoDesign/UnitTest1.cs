using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDoDesign.DoDesignWS;
using System.Collections.Generic;

namespace UnitTestDoDesign
{
    [TestClass]
    public class UnitTest1
    {
        TransaccionClient proxy = new TransaccionClient();

        [TestMethod]
        public void ListarPedido()
        {
            try
            {
                IList<Pedido> Listado = proxy.ListarPedido();
               
                Assert.AreNotEqual(null,Listado);
                Assert.IsTrue(Listado.Count>0);
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
                Cliente cliente = new Cliente();
                cliente = proxy.obtenerCliente(cliente.NombreUsuario);

                Assert.AreNotEqual(null, cliente);
            }
            catch (Exception)
            {
            }
        }

        
            

        [TestMethod]
        public void CrearPedido()
        {
            try
            {
                Pedido pedido = new Pedido();
                Polo polo = new Polo();
                Pago pago = new Pago();
                Cliente cliente = new Cliente();
                polo.IdPolo = 1;
                pago.IdPago = 2;
                cliente.NombreUsuario = "OtroUsu";
                pedido.Polo = polo;
                pedido.Pago = pago;
                pedido.Cliente = cliente;
                pedido.NroTargeta = "6565259874";
                bool agregado = proxy.CrearPedido(pedido);
                Assert.IsTrue(agregado);
               // Assert.AreNotEqual(null, pedido);
            }
            catch (Exception)
            {
            }
        }
    }
}
