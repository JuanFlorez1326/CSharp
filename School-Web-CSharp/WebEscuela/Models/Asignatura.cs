using System;
using System.Collections.Generic;

namespace WebEscuela.Models
{
    public class Asignatura:ObjetoEscuelaBase
    {
        public string CursoId { set; get; }
        public Curso Curso { set; get; }
        public  List<Evaluaci�n> Evaluaciones { set; get; }
    }
}