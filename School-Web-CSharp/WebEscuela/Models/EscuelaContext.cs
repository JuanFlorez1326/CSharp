using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEscuela.Models
{
    public class EscuelaContext: DbContext
    {
        public DbSet<Escuela> Escuelas { set; get; }
        public DbSet<Asignatura> Asignaturas { set; get; }
        public DbSet<Alumno> Alumnos { set; get; }
        public DbSet<Curso> Cursos { set; get; }
        public DbSet<Evaluación> Evaluacións { set; get; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options): base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var school = new Escuela();
            school.AñoDeCreacion = 2000;
            school.Id = Guid.NewGuid().ToString();
            school.Nombre = "Rose School";
            school.Dirección = "Sin direccion";
            school.Ciudad = "Armenia";
            school.Pais = "Colombia";
            school.TipoEscuela = TiposEscuela.Secundaria;


            //Cargar cursos escuela
            var cursos = CargarCursos(school);

            //por cada curso cargar asignaturas
            var asignaturas = CargarAsignaturas(cursos);

            //por cada curso cargar alumnos
            var alumnos = CargarAlumnos(cursos);

            modelBuilder.Entity<Escuela>().HasData(school);
            modelBuilder.Entity<Curso>().HasData(cursos.ToArray());
            modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());
            modelBuilder.Entity<Alumno>().HasData(alumnos.ToArray());

            //Cargar evaluaciones = tarea

        }

        private List<Alumno> CargarAlumnos(List<Curso> cursos)
        {
            var listaAlumnos = new List<Alumno>();
            Random rnd = new Random();
            foreach(var curso in cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                var tmplist = GenerarAlumnosAlAzar(curso, cantRandom);
                listaAlumnos.AddRange(tmplist);
            }
            return listaAlumnos;
        }
        private static List<Asignatura> CargarAsignaturas(List<Curso> cursos)
        {
            var listaCompleta = new List<Asignatura>();

            foreach (var curso in cursos)
            {
                var tmplist = new List<Asignatura>
                {
                    new Asignatura
                    {
                        Id = Guid.NewGuid().ToString(),
                        CursoId = curso.Id,
                        Nombre = "Matematicas"
                    },
                    new Asignatura
                    {
                        Id = Guid.NewGuid().ToString(),
                        CursoId = curso.Id,
                        Nombre = "Educacion Fisica"
                    },
                    new Asignatura
                    {
                        Id = Guid.NewGuid().ToString(),
                        CursoId = curso.Id,
                        Nombre = "Castellano"
                    },
                    new Asignatura
                    {
                        Id = Guid.NewGuid().ToString(),
                        CursoId = curso.Id,
                        Nombre = "Ciencias Naturales"
                    },
                    new Asignatura
                    {
                        Id = Guid.NewGuid().ToString(),
                        CursoId = curso.Id,
                        Nombre = "Programacion"
                    }
                };
                listaCompleta.AddRange(tmplist);
                //curso.Asignaturas = tmplist;
            }
            return listaCompleta;
        }

        private static List<Curso> CargarCursos(Escuela school)
        {
            return new List<Curso>()
            {
                new Curso()
                {
                    Id = Guid.NewGuid().ToString(),
                    EscuelaId = school.Id,
                    Nombre = "101",
                    Jornada = TiposJornada.Mañana
                },
                new Curso()
                {
                    Id = Guid.NewGuid().ToString(),
                    EscuelaId = school.Id,
                    Nombre = "201",
                    Jornada = TiposJornada.Mañana
                },
                new Curso()
                {
                    Id = Guid.NewGuid().ToString(),
                    EscuelaId = school.Id,
                    Nombre = "301",
                    Jornada = TiposJornada.Mañana
                },
                new Curso()
                {
                    Id = Guid.NewGuid().ToString(),
                    EscuelaId = school.Id,
                    Nombre = "401",
                    Jornada = TiposJornada.Tarde
                },
                new Curso()
                {
                    Id = Guid.NewGuid().ToString(),
                    EscuelaId = school.Id,
                    Nombre = "501",
                    Jornada = TiposJornada.Tarde
                }
            };
        }

        private List<Alumno> GenerarAlumnosAlAzar(Curso curso,int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno
                               {
                                   CursoId = curso.Id,
                                   Nombre = $"{n1} {n2} {a1}",
                                   Id = Guid.NewGuid().ToString()
                               };

            return listaAlumnos.OrderBy((al) => al.Id).Take(cantidad).ToList();
        }
    }
}
