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
    public partial class Ejer5 : Form
    {
        public Ejer5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int caso = int.Parse(textBoxNumeroEscrito.Text);
            switch (caso)
            {
                case 1:
                    MessageBox.Show("Uno");
                    break;
                case 2:
                    MessageBox.Show("Dos");
                    break;
                case 3:
                    MessageBox.Show("Tres");
                    break;
                case 4:
                    MessageBox.Show("Cuatro");
                    break;
                case 5:
                    MessageBox.Show("Cinco");
                    break;
                case 6:
                    MessageBox.Show("Seis");
                    break;
                case 7:
                    MessageBox.Show("Siete");
                    break;
                case 8:
                    MessageBox.Show("Ocho");
                    break;
                case 9:
                    MessageBox.Show("Nueve");
                    break;
                default:
                    MessageBox.Show("Numero Fuera de rango intente de nuevo");
                    break;
            }

        }
    }
}
