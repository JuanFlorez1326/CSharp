using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEscuela.Models;

namespace WebEscuela.Controllers
{
    public class EscuelaController : Controller
    {

        private EscuelaContext _context;
        public IActionResult Index()
        {
            ViewBag.DatoDinamico = "School Days";
            var school = _context.Escuelas.FirstOrDefault();
            return View(school);
        }

        public EscuelaController(EscuelaContext context)
        {
            _context = context;
        }
    }
}
