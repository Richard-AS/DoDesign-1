using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebWCF.TransWS;

namespace WebWCF.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente

        TransaccionClient proxy = new TransaccionClient();

        public ActionResult ListCliente()
        {
            var proxy = new TransaccionClient();
            var ListaCliente = proxy.ListarCliente();
            return View(ListaCliente);
        }

        public ActionResult NewCliente()
        {
            var proxy = new TransaccionClient();
            var ListaTLogin = proxy.ListarTLogin();
            ViewBag.IdTLogin = new SelectList(ListaTLogin, "IdTLogin", "NombreUsuario");
            return View();
        }

        [HttpPost]
        public ActionResult NewCliente(Cliente cliente, int IdTLogin)
        {
            var proxy = new TransaccionClient();
            var login = proxy.ObtenerTLogin(IdTLogin);
            cliente.IdTLogin = login;
            proxy.CrearCliente(cliente);
            return RedirectToAction("ListCliente");
        }
    }
}