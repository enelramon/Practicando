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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = 0, numeroPrimo = 0;
            for (int i = 1; i <= 1000; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    resultado = i % j;
                    if (resultado == 0)
                    {
                        numeroPrimo = numeroPrimo + 1;
                    }
                }
                if (numeroPrimo == 2)
                {
                    listBoxPrimo.Items.Add(i);
                }
                numeroPrimo = 0;
            }
        }
    }
}
