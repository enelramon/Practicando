using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios456.Ejercicios4;
using Ejercicios456.Ejercicios5;

namespace Ejercicios456
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejercicios1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicios1 ejercicios = new Ejercicios1();
            //ejercicios.MdiParent = this;
            ejercicios.Show();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ejercicios2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio2 ejercicios = new Ejercicio2();
            ejercicios.Show();
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio5 ejercicios = new Ejercicio5();
            ejercicios.Show();
        }

        private void ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           Ejer1 ejercicios = new Ejer1();
            ejercicios.Show();
        }

        private void ejercicio2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ejer2 ejercicios = new Ejer2();
            ejercicios.Show();
        }

        private void ejercicio3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Ejer3 ejercicios = new Ejer3();
            ejercicios.Show();
        }

        private void ejercicio4ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Ejer4 ejercicios = new Ejer4();
            ejercicios.Show();
        }

        private void ejercicio5ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Ejer5 ejercicios = new Ejer5();
            ejercicios.Show();
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio4 ejercicios = new Ejercicio4();
            ejercicios.Show();
        }
    }
}
