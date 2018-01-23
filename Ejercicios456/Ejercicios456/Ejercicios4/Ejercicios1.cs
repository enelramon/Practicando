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
    public partial class Ejercicios1 : Form
    {
        public Ejercicios1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            int resultado = 0;

            n = int.Parse(textBoxNumero.Text);
            for (int i = 1; i <= 10; i++)
            {
                resultado = n * i;
              
               MessageBox.Show(n + "x" + i + "=" + resultado);
            }
            
        }
    }
}
