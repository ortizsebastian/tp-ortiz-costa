using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_winforms_catalogo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsmi1_listarArticulos_Click(object sender, EventArgs e)
        {
            frmListarTodos ListarTodos = new frmListarTodos();
            ListarTodos.ShowDialog();
        }

        private void tsmi2_modificarArticulos_Click(object sender, EventArgs e)
        {
            frmModificar ModificarArticulo = new frmModificar();
            ModificarArticulo.ShowDialog();
        }

        private void tsmi3_agregarArticulos_Click(object sender, EventArgs e)
        {
            frmAgregar AgregarArticulo = new frmAgregar();
            AgregarArticulo.ShowDialog();
        }

        private void tsmi4_eliminarArticulos_Click(object sender, EventArgs e)
        {
            frmEliminar EliminarArticulo = new frmEliminar();
            EliminarArticulo.ShowDialog();
        }

        private void tsmi5_verArticulo_Click(object sender, EventArgs e)
        {
            frmListarUno ListarUno = new frmListarUno();
            ListarUno.ShowDialog();
        }
    }
}
