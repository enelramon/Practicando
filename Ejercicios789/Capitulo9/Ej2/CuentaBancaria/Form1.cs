using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CuentaBancaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CuentaBancariaDatos cuenta = new CuentaBancariaDatos();

            cuenta.ConstrañaCuenta = Passtext.Text;
            cuenta.DineroCuenta = DineroText.Text;
            cuenta.NombrePropietario = NombreText.Text;
            cuenta.UsuarioCuenta = UsuarioCuenta.Text;
            cuenta.NumeroCuenta = NumeroCuentamasked.Text;



            MessageBox.Show("Numero de la cuneta es :" + NumeroCuentamasked.Text + "\n Nombre del propietario de la cuenta  :" + NombreText.Text +
                "\n Cantidad de dinero en la cuenta :" + DineroText.Text + "\n Usuario de la cuenta :" + UsuarioCuenta.Text+"Contraseña de la cuenta :" +Passtext.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
