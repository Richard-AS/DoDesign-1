using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebWCF.TransWS;

namespace WebWCF.Controllers
{
    public class ColorController : Controller
    {
        // GET: Color
        public ActionResult ListColor()
        {
            TransaccionClient proxy = new TransaccionClient();
            var ListaColor = proxy.ListarColor();
            return View(ListaColor);
        }
    }
}