using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(num1.Text);
            int numero2 = int.Parse(num2.Text);

            int suma = numero1 + numero2;

            MessageBox.Show("La suma da " + suma);
        }

        private void resta_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(num1.Text);
            int numero2 = int.Parse(num2.Text);

            int resta = numero1 - numero2;

            MessageBox.Show("La resta da " + resta);
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(num1.Text);
            int numero2 = int.Parse(num2.Text);

            int multiplicacion = numero1 * numero2;

            MessageBox.Show("La multiplicacion da " + multiplicacion);
        }

        private void division_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(num1.Text);
            int numero2 = int.Parse(num2.Text);

            int division = numero1 / numero2;

            MessageBox.Show("La division da " + division);
        }
    }
}
