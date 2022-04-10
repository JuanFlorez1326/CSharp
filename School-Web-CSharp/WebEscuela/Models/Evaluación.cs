using System;

namespace WebEscuela.Models
{
    public class Evaluación:ObjetoEscuelaBase
    {
        public Alumno Alumno { get; set; }
        public string AlumnoId { set; get; }
        public Asignatura Asignatura  { get; set; }
        public string  AsignaturaId { set; get; }

        public float Nota { get; set; }

        public override string ToString()
        {
            return $"{Nota}, {Alumno.Nombre}, {Asignatura.Nombre}";
        }
    }
}