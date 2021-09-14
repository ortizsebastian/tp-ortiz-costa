using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void tsmi_listarArticulos_Click(object sender, EventArgs e)
        {
            frmListarTodos ListarTodos = new frmListarTodos();
            ListarTodos.ShowDialog();
        }
        private void tsmi_agregarArticulos_Click(object sender, EventArgs e)
        {
            frmAgregar AgregarArticulo = new frmAgregar();
            AgregarArticulo.ShowDialog();
        }
        private void tsmi_eliminarArticulos_Click(object sender, EventArgs e)
        {
            frmEliminar EliminarArticulo = new frmEliminar();
            EliminarArticulo.ShowDialog();
        }
        private void tsmi_verArticulo_Click(object sender, EventArgs e)
        {
            frmListar ListarUno = new frmListar();
            ListarUno.ShowDialog();
        }
    }
}
