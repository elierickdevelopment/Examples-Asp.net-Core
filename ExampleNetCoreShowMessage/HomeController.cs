using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EjemploNetCoreMostrarMensaje2.Models;
using Microsoft.AspNetCore.Http;


namespace EjemploNetCoreMostrarMensaje2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()

        {
            //TempData["Message"] = "La página cargó correctamente.";
            return View();
        }

        //[HttpGet]
        //public IActionResult ShowMensaje1( string ValueBtn){
        //    //REQUERIDO USAR TEMPDATA:
        //     TempData["Message"]= "Acción click btn 1.";

        //    var valor = ValueBtn;
        //    //ALTERNAATIVO JAVASCRIPT:
        //    // ViewBag.Message = string.Format("Hello {0}.\\nCurrent Date and Time: {1}", "CLIC EN EL BTN 1", DateTime.Now.ToString());

        //    return View();
        //}

        [HttpGet]
        public void ShowMensaje1(string ValueBtn)
        {
            //REQUERIDO USAR TEMPDATA:
            TempData["Message"] = "Acción click btn 1.";

            var valor = ValueBtn;
            //ALTERNAATIVO JAVASCRIPT:
            // ViewBag.Message = string.Format("Hello {0}.\\nCurrent Date and Time: {1}", "CLIC EN EL BTN 1", DateTime.Now.ToString());

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
