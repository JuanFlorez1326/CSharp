using POO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POO.Controllers
{
    public class PersonasController
    {

        BaseDatos bd = new BaseDatos();

        public string insertarPersonas(string nombre, string apellido, string edad,string sexo)
        {
            string sql = "INSERT INTO trabajadores.personas (Nombre,Apellido,Edad,Sexo) VALUES ('" + nombre + "','" + apellido + "','" + edad + "','" + sexo + "')";
            string resultado = bd.ejecutarSQL(sql);
            return resultado;
        }

        public string actualizarPersonas(int id, string nombre, string apellido, string edad, string sexo)
        {
            string sql = "UPDATE trabajadores.personas SET Nombre = '" + nombre + "', Apellido = '" + apellido +"', Edad = '"+ edad +"', Sexo ='"+ sexo +"'  WHERE idPersona = '"+ id +"'";
            string resultado = bd.ejecutarSQL(sql);
            return resultado;
        }

        public string eliminarPersonas(int id)
        {
            string sql = "DELETE FROM trabajadores.personas WHERE idPersona = "+id;
            string resultado = bd.ejecutarSQL(sql);
            return resultado;
        }

        public string mostrarTodo(int id)
        {
            string sql = "SELECT * FROM trabajadores.personas WHERE idPersona = "+id;          
            string resultado = bd.ejecutarSQL(sql);
            return resultado;

        }
        public string mostrarPersona(int id)
        {
            string sql = "SELECT personas.idPersona,personas.nombre,personas.apellido,personas.edad,personas.sexo FROM trabajadores.personas WHERE idPersona = " + id + "";
            string resultado = bd.mostrarSQL(sql);
            return resultado;

        }
    }
}
