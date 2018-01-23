using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EstructuraTienda tienda = new EstructuraTienda();
            tienda.Cantidad = maskedTextBox1.Text;
            tienda.CodigoBarras= maskedTextBox3.Text;
            tienda.NombreProducto = textBox2.Text;
            tienda.Precio = maskedTextBox2.Text;

            MessageBox.Show("Cantidad producto es :"+ maskedTextBox1.Text+ "\n Codigo de Barras producto es :" + maskedTextBox3.Text+
                "\n Nombre del producto es :" + textBox2.Text+ "\n Precio del producto es :" + maskedTextBox2.Text);
          


        }
    }
}
