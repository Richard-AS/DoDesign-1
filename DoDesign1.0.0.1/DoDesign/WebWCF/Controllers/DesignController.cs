using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebWCF.TransWS;

namespace WebWCF.Controllers
{
    public class DesignController : Controller
    {
        TransaccionClient proxy = new TransaccionClient();

        // GET: Design
        public ActionResult ListDesign()
        {
            var proxy = new TransaccionClient();
            var ListaDesign = proxy.ListarDesign();
            return View(ListaDesign);
        }
        public ActionResult NewDesign()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewDesign(Design design)
        {
            var proxy = new TransaccionClient();
             proxy.CrearDesign(design);
            return RedirectToAction("ListDesign");
        }
    }
}