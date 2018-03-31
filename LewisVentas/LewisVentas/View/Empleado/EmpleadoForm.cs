using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LewisVentas.BLL;
using LewisVentas.ENTIDADES;

namespace LewisVentas.View.Empleado
{
    public partial class EmpleadoForm : Form
    {
        public EmpleadoForm()
        {
            InitializeComponent();
        }

        private void EmpleadoForm_Load(object sender, EventArgs e)
        {
            LlenaCampos();
        }

        private void LlenaCampos()
        {
            List<Users> usuarios = UsersBLL.listar();
            foreach (Users usuario in usuarios)
            {
                dataGridViewEmpleado.Rows.Add(usuario.IdUsuario, usuario.Nombre,usuario.Nombre, usuario.Email, usuario.Tipo, usuario.Pass);
            }
           
           
        }

      

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpleado.SelectedRows.Count > 0)
            {
               
                EditarForm editar = new EditarForm();
                editar.Nombre = dataGridViewEmpleado.CurrentRow.Cells["ColumnNombre"].Value.ToString();
                editar.Id =(int) dataGridViewEmpleado.CurrentRow.Cells["ColumnId"].Value;
                editar.Tipo = dataGridViewEmpleado.CurrentRow.Cells["ColumnTipo"].Value.ToString();
                editar.NombreUsuario = dataGridViewEmpleado.CurrentRow.Cells["ColumnUsuario"].Value.ToString();
                editar.Email = dataGridViewEmpleado.CurrentRow.Cells["ColumnEmail"].Value.ToString();
                editar.Pass = dataGridViewEmpleado.CurrentRow.Cells["ColumnPass"].Value.ToString();
                editar.ShowDialog();
                dataGridViewEmpleado.Rows.Clear();
                LlenaCampos();

            }
            else
            {
                MessageBox.Show("Por favor selecione una fila!");
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            EditarForm editar = new EditarForm();
            editar.ShowDialog();
            dataGridViewEmpleado.Rows.Clear();
            LlenaCampos();
        }

        public void Refrescar()
        {
            dataGridViewEmpleado.Hide();
        }

        private void dataGridViewEmpleado_MouseHover(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpleado.SelectedRows.Count > 0)
            {
               
               int Id = (int)dataGridViewEmpleado.CurrentRow.Cells["ColumnId"].Value;
                if(UsersBLL.eliminar(Id) == true)
                {
                    MessageBox.Show("Se elemino con exicto!");
                }
                else
                {
                    MessageBox.Show("Error, no se pudo eliminar!");
                }



            }
            else
            {
                MessageBox.Show("Por favor selecione una fila!");
            }

        }
    }
}
