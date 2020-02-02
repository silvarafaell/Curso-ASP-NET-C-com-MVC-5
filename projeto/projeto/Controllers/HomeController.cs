using projeto.Models;
using System.Web.Mvc;

namespace projeto.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa() 
            {

            }

            return View();
        }

        public ActionResult Contatos()
        {
            return View();
        }

    }
}