using POO.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using POO.Models;

namespace POO
{
    public partial class Form1 : Form
    {
        PersonasController personasC = new PersonasController();

        public Form1()
        {
            InitializeComponent();
        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            string resultado = personasC.insertarPersonas(tbNombre.Text, tbApellido.Text, tbEdad.Text, tbSexo.Text);
            MessageBox.Show(resultado);
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            string resultado = personasC.actualizarPersonas(Convert.ToInt32(tbId.Text),tbNombre.Text, tbApellido.Text, tbEdad.Text, tbSexo.Text);
            MessageBox.Show(resultado);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            string resultado = personasC.eliminarPersonas(Convert.ToInt32(tbId.Text));
            MessageBox.Show(resultado);
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string resultado = personasC.mostrarPersona(Convert.ToInt32(tbId.Text));
            MessageBox.Show(resultado);
        }

        private void btTodo_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexionDB = BaseDatos.conex();
                conexionDB.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionDB;
                comando.CommandText = ("SELECT * FROM trabajadores.personas;");

                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dataGridView1.DataSource = tabla;
                conexionDB.Close();
            }
            catch (Exception b)
            {

                MessageBox.Show(b.Message + b.StackTrace);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
