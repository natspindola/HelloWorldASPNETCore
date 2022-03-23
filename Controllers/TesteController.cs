using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldASPNETCore.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Mensagem = "Fui gerado pela ferramenta de scaffolding";
            return View();
        }
    }
}