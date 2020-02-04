using projeto.Models;
using System.Web.Mvc;

namespace projeto.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Francisco Rafael",
                Tipo = "Administrador"

            };

            return View(pessoa);
        }

        public ActionResult Contatos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lista(int PessoaId, string Nome, string Tipo)
        {
            ViewData["PessoaId"] = PessoaId;
            ViewData["Nome"] = Nome;
            ViewData["Tipo"] = Tipo;
            return View();
        }

    }
}