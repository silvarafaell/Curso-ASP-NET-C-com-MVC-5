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

            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;

            return View();
        }

        public ActionResult Contatos()
        {
            return View();
        }

    }
}