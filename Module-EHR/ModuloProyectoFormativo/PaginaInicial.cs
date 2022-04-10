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
    public partial class PaginaInicial : Form
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            PropietariosCasas Casas = new PropietariosCasas();
            Casas.ShowDialog();
            this.Close();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Casa1 Casa01 = new Casa1();
            Casa01.ShowDialog();
            this.Close();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Casa2 Casa02 = new Casa2();
            Casa02.ShowDialog();
            this.Close();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Casa3 Casa03 = new Casa3();
            Casa03.ShowDialog();
            this.Close();
        }
    }
}
