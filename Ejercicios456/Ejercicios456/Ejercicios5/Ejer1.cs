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
    public partial class Ejer1 : Form
    {
        public Ejer1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grados(int.Parse(textBoxGrado.Text));
        }
        private static void grados(float grado){
            
            float resultado = 0f;
            resultado = 3.15f * grado;

           MessageBox.Show(" Resultado en Radianes es " + resultado); // Escribe por pantalla un string 

        }
}
}
