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
using System.Resources;

namespace ProyectoFinalVentas
{
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
        }
       [DllImport("user32.DLL",EntryPoint="ReleaseCapture")] 
       private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
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

        private void pictureBoxMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBoxMaximizar.Visible = false;
            pictureBoxRestaurar.Visible = true;
        }

        private void pictureBoxRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBoxMaximizar.Visible =true;
            pictureBoxRestaurar.Visible = false;
        }

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelMenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);

        }

        private void lewisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Template_Load(object sender, EventArgs e)
        {

        }

    }
}
