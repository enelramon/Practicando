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
    public partial class Ejer4 : Form
    {
        public Ejer4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           factorial(int.Parse(textBoxFactorial.Text));
        }

        static void factorial(int n)
        {
            

            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            MessageBox.Show("El Factorial de " + n + " es: " + fact);
        }

    }
}
