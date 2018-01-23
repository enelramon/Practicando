using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios456.Ejercicios4
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            double numero = 0;
            double potencia = 0;

           
            numero = int.Parse(textBoxElevar.Text);

            
            potencia = int.Parse(textBoxPotencia.Text);

            resultado = Math.Pow(numero, potencia);

           MessageBox.Show("Resultado " + resultado);

            
        }
    }
}
