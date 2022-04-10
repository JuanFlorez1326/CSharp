using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO.Models
{
    public class BaseDatos
    {


        public MySqlConnection connection;

        public BaseDatos()
        {
            connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=Juan67927;database=trabajadores;SSLMode=None");
        }

        public string ejecutarSQL(string sql)
        {
            string resultado = "";

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(sql, connection);

            int filasResultado = cmd.ExecuteNonQuery();

            if(filasResultado > -1)
            {
                resultado = "Correcto";
            }
            else
            {
                resultado = "Incorrecto";
            }

            connection.Close();


            return resultado;
        }


        public static MySqlConnection conex()
        {
            string servidor = "server=localhost; database=trabajadores; Uid=root; SSLMode=None; pwd=" ;

            MySqlConnection conexionBD = new MySqlConnection(servidor);

            try
            {
                return conexionBD;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
                return null;
            }
        }

        public string mostrarSQL(string sql)
        {
            MySqlCommand commandDatabase = new MySqlCommand(sql,connection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            string resultado = "";

            try
            {
                connection.Open();
                reader = commandDatabase.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        resultado = (reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3) + " - " + reader.GetString(4));
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro nada");
                }
                connection.Close();
                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return resultado;
            }
        }
    }
}
