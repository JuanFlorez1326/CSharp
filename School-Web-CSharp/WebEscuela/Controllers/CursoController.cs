using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEscuela.Models;

namespace WebEscuela.Controllers
{
    public class CursoController : Controller
    {

        //[Route("Alumno/Index")]
        //[Route("Alumno/Index/{id}")]
        public IActionResult Index(string id)
        {

            if (!string.IsNullOrWhiteSpace(id))
            {
                var curso = from cur in _context.Cursos
                             where cur.Id == id
                             select cur;

                return View(curso.FirstOrDefault());
            }
            else
            {
                return View("MultiCurso", _context.Cursos);
            }
        }
        public IActionResult MultiCurso()
        {

            ViewBag.DatoDinamico = "School Days";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiCurso",_context.Cursos);
        }

        private EscuelaContext _context;
        public CursoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}
