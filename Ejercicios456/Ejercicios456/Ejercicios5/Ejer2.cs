using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios456.Ejercicios5
{
    public partial class Ejer2 : Form
    {
        public Ejer2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcular(int.Parse(textBoxGF.Text));
        }

        static void calcular(float gradoF)
        {
            float resultado = 0f;
            resultado = (gradoF * 9 / 5) + (32);

            MessageBox.Show("Resultado es " + resultado+ " grados Fahrenheit");


        }
    }
}
