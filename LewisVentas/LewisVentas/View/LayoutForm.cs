using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LewisVentas.View.Empleado;
using LewisVentas.ENTIDADES;
using LewisVentas.BLL;

namespace LewisVentas.View
{
    public partial class LayoutForm : Form
    {
        public LayoutForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void LayoutForm_Load(object sender, EventArgs e)
        {
           // LlenaCampos(Program.Id);
            PrivilegiosUsuarios();
        }

        private void PrivilegiosUsuarios()
        {
            if (Program.TipoUsuario == "Vendedor")
            {
             
            }
        }

        private void pictureBoxSlider_Click(object sender, EventArgs e)
        {
            if (panelMenuVertical.Width == 250)
            {
                panelMenuVertical.Width = 47;
            }
            else
            {
                panelMenuVertical.Width = 250;
            }
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMaximixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBoxMaximixar.Visible = false;
            pictureBoxRestaurar.Visible = true;
        }

        private void pictureBoxRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBoxMaximixar.Visible = true;
            pictureBoxRestaurar.Visible = false;
        }

        private void pictureBoxMinimixar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      
        private void PonerFormEnPanel(object FormHijo)
        {
            if (this.panelCenter.Controls.Count > 0)
                this.panelCenter.Controls.RemoveAt(0);
                Form Usuarios = FormHijo as Form;
                Usuarios.TopLevel = false;
                Usuarios.Dock = DockStyle.Fill;
                Usuarios.Size = new Size(50, 50);
                Usuarios.BackColor = Color.White;
                this.panelCenter.Controls.Add(Usuarios);
                this.panelCenter.Tag = Usuarios;
                Usuarios.Show();
        }
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PonerFormEnPanel(new EmpleadoForm());
        }

        private void LlenaCampos(int Id)
        {
            Users User = UsersBLL.Buscar(Id);
            labelNombreUser.Text = User.Nombre;
            labelEmail.Text = User.Email;
            labelTipo.Text = User.Tipo;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PonerFormEnPanel(new EmpleadoForm());
        }
    }
}
