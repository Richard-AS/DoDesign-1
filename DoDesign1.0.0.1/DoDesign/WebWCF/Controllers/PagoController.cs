using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using WebWCF.TransWS; 


namespace WebWCF.Controllers
{
    public class PagoController : Controller
    {
        TransaccionClient proxy = new TransaccionClient();

        // GET: Pago
        public ActionResult ListPago()
        {
            var proxy = new TransaccionClient();
            var ListaPago = proxy.ListarPago();
            return View(ListaPago);
        }
    }
}