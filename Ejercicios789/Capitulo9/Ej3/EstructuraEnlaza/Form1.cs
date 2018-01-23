using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstructuraEnlaza
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
           
    }

    private void button1_Click(object sender, EventArgs e)
        {

          


            Lista lista = new Lista();
            lista.addNodo(" Juan  ", " Lasi");
            lista.ListaVacia();
          
            lista.Listar();

          
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          

        }
    }
}

