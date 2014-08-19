using MVC1ejemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1ejemplo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];

            var message = String.Format("{0} {1} {2}", controller, action, id);
            ViewBag.Message = "asdfas";
            return View();
        }

        public ActionResult About()
        {
            //instancio un Model nuevo de AboutModel()
            var model = new AboutModel();
            //Asigno valores a las propiedades del Model.
            model.Nombre = "Dario";
            model.Ubicacion = "Asuncion";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
