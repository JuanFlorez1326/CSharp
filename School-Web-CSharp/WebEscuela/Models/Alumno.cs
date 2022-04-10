using System;
using System.Collections.Generic;

namespace WebEscuela.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public string CursoId { set; get; }
        public Curso Curso { set; get; }
        public List<Evaluación> Evaluaciones { get; set; }
    }
}