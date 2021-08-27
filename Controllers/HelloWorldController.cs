using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string nombre, int cant = 1)
        {
            ViewData["msj"] = $"Hola, {nombre}";
            ViewData["cant"] = cant;

            return View();
        }
    }
}