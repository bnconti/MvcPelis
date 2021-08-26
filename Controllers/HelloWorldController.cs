using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "La acción/método por defecto al invocar al controlador es Index";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string nombre)
        {
            return HtmlEncoder.Default.Encode($"Hola, {nombre}");
        }
    }
}