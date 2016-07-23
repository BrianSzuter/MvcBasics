using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace MvcBasics.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return this.View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(string name="Anonymous", int numTimes = 1)
        {
            this.ViewData["Message"] = "Hello Lord " + name;
            this.ViewData["NumTimes"] = numTimes;

            return this.View();
        }
    }
}
