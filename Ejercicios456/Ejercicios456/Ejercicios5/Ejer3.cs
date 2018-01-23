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
    public partial class Ejer3 : Form
    {
        public Ejer3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcular(int.Parse(textBoxCantidaLados.Text), int.Parse(textBoxTamano.Text));
        }

        static void calcular(int lados, int tamano)
        {
            double perimetro = 0;
            perimetro = tamano * lados;


            MessageBox.Show("El Area del Poligono : " + perimetro);


        }
    }
}
