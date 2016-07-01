using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebWCF.TransWS;

namespace WebWCF.Controllers
{
    public class TLoginController : Controller
    {

        TransaccionClient proxy = new TransaccionClient();

        // GET: TLogin
        public ActionResult ListTLogin()
        {
            var proxy = new TransaccionClient();
            var ListaLogin = proxy.ListarTLogin();
            return View(ListaLogin);
        }

        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registro(TLogin tlogin)
        {
            var proxy = new TransaccionClient();
            proxy.CrearTLogin(tlogin);
            return RedirectToAction("ListTLogin");
        }
    }
}