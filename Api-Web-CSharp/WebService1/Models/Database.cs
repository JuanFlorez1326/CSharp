using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebService1.Models
{
    public class BaseDatos
    {
        MySqlConnection connection;

        public BaseDatos()
        {
            connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=Juan67927;database=dbfacturas;SSLMode=None");
        }

        public string consultaSQL(string sql)
        {
            string resultado = "";

            try
            {
                connection.Open();

                MySqlCommand comand = new MySqlCommand(sql, connection);
                int resultCount = comand.ExecuteNonQuery();

                if (resultCount > -1)
                {
                    resultado = "Correcto";
                }
                else
                {
                    resultado = "Incorrecto";

                }

                connection.Close();
            }
            catch
            {
                resultado = "Error";
            }

            return resultado;
        }


        public DataTable getTabla(string sql)
        {
            DataTable dt = new DataTable();

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(sql, connection);


                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                adapter.Fill(dt);

                connection.Close();
                adapter.Dispose();
            }
            catch
            {
                dt = null;
            }
            return dt;
        }

        internal string ExecuteQuery(string sql)
        {
            throw new NotImplementedException();
        }
    }
}