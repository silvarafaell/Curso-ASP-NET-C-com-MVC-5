using projeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projeto.Controllers
{
    public class UsuarioController : Controller
    {
        
        public ActionResult Usuario()
        {
            var usuario = new Usuario();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {
            if(string.IsNullOrEmpty(usuario.Nome))
            {
                ModelState.AddModelError("Nome", "O campo nome é obrigatorio");
            }

            if(ModelState.IsValid)
            {
                return View("resultado", usuario);
            }
            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }
    }
}