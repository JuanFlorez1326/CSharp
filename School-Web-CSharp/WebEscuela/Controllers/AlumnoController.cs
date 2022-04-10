using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEscuela.Models;

namespace WebEscuela.Controllers
{
    public class AlumnoController : Controller
    {

        //[Route("Alumno/Index")]
        //[Route("Alumno/Index/{id}")]
        public IActionResult Index(string id)
        {

            if (!string.IsNullOrWhiteSpace(id))
            {
                var alumno = from alum in _context.Alumnos
                             where alum.Id == id
                             select alum;

                return View(alumno.FirstOrDefault());
            }
            else
            {
                return View("MultiAlumno", _context.Alumnos);
            }
        }
        public IActionResult MultiAlumno()
        {

            ViewBag.DatoDinamico = "School Days";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAlumno",_context.Alumnos);
        }

        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}
