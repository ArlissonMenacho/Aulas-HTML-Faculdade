using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FibraOticaBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace FibraOticaBlog.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(Cliente cliente)
        {
            return RedirectToAction("home.cshtml");
        }
    }
}