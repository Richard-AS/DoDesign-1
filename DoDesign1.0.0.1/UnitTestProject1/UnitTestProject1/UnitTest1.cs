using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


using UnitTestProject1.ws;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        TransaccionClient proxy = new TransaccionClient();
        [TestMethod]
        public void TestMethod1()
        {

            try
            {
                TLogin logueo = new TLogin();
                logueo.NombreUsuario = "tupapa";
                logueo.Contrasenia = "E4FED62DEA164D6DC7A2803F25AF40DBED728A95";
                bool logueado = proxy.LoginCliente(logueo);
                Assert.IsTrue(logueado);
            }
            catch (Exception)
            {
                
                throw;
            }
            

        }
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
                Cliente = cliente,
                NroTargeta = "9556554584"
            };
            TransaccionClient proxy = new TransaccionClient();
            proxy.CrearPedido(pedido);
            Assert.AreNotEqual(null, pedido);

        }

        [TestMethod]
        public void CrearPago()
        {
            Pago pago = new Pago()
            {
                Tipo="Tarjeta"

            };
            TransaccionClient proxy = new TransaccionClient();
            proxy.CrearPago(pago);
            Assert.AreNotEqual(null, pago);

        }
    }
}
