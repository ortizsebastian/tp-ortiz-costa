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
    public partial class frmListarUno : Form
    {
        public frmListarUno()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmMain to = new frmMain();
            to.Show();
            this.Close();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvBuscarUno.DataSource = ConexionSqlAgregar.buscarArticulo(txtBuscarCodigo.Text);
        }

        private void btnSeleccionarMod_Click(object sender, EventArgs e)
        {
            if (dgvBuscarUno.SelectedRows.Count == 1)
            {

            }
        }
    }
}
