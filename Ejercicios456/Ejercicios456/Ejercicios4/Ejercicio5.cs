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
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            
            
            int s = 0;
            int[] edades = new int[6];
            edades[0] = int.Parse(textBoxEdad1.Text);
            edades[1] = int.Parse(textBoxEdad2.Text);
            edades[2] = int.Parse(textBoxEdad3.Text);
            edades[3] = int.Parse(textBoxEdad4.Text);
            edades[4] = int.Parse(textBoxEdad5.Text);
            edades[5] = int.Parse(textBoxeEdad6.Text);


            for (int id = 0; id < edades.Length; id++)
            {
                //Console.WriteLine("Edad {0}: {1}", id, edades[id]);
                    s += edades[id];
            }

            MessageBox.Show("La suma de edades es " + s);
            MessageBox.Show("Promedio de edades es " + s / edades.Length);

            Array.Sort(edades);
            MessageBox.Show("Edad menor es: " + edades[0]);
            Array.Reverse(edades);
            MessageBox.Show("Edad mayor es: " + edades[0]);




            
        }
    }
}
