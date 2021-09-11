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
            frmListarTodos to = new frmListarTodos();
            to.Show();
            this.Hide();
            
            //frmListarTodos ListarTodos = new frmListarTodos();
            //ListarTodos.ShowDialog();
        }

        private void tsmi2_modificarArticulos_Click(object sender, EventArgs e)
        {
            frmModificar to = new frmModificar();
            to.Show();
            this.Hide();

            //frmModificar ModificarArticulo = new frmModificar();
            //ModificarArticulo.ShowDialog();
        }

        private void tsmi3_agregarArticulos_Click(object sender, EventArgs e)
        {
            frmAgregar to = new frmAgregar();
            to.Show();
            this.Hide();

            //frmAgregar AgregarArticulo = new frmAgregar();
            //AgregarArticulo.ShowDialog();
        }

        private void tsmi4_eliminarArticulos_Click(object sender, EventArgs e)
        {
            frmEliminar to = new frmEliminar();
            to.Show();
            this.Hide();

            //frmEliminar EliminarArticulo = new frmEliminar();
            //EliminarArticulo.ShowDialog();
        }

        private void tsmi5_verArticulo_Click(object sender, EventArgs e)
        {
            frmListarUno to = new frmListarUno();
            to.Show();
            this.Hide();
            
            //frmListarUno ListarUno = new frmListarUno();
            //ListarUno.ShowDialog();
        }

        private void busquedaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusqueda to = new frmBusqueda();
            to.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
