using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloProyectoFormativo
{
    public partial class RegistroLogin : Form
    {
        ClassLogin Usuario = new ClassLogin();

        public RegistroLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NombreUsuario = rNombre.Text;
            string Correo = rCorreo.Text;
            string Contraseña = rContraseña.Text;
            string Identificacion = rIdentificacion.Text;
            string Fecha = rFechaN.Text;
            string Telefono = rTelefono.Text;


            Usuario.RegistroUsuario(NombreUsuario, Correo, Contraseña, Identificacion, Fecha, Telefono);

            this.Hide();
            Login pUsuarios = new Login();
            pUsuarios.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
