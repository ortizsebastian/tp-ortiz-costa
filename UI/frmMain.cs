using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace UI
{
    public partial class frmMain : Form
    {
        private List<Articulo> ListaArticulos;
        private Articulo articuloSeleccionado = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private Form frmActivo = null;
        private void frmInterno(Form frmInterno)
        {
            if (frmActivo != null)
                frmActivo.Close();
            frmActivo = frmInterno;
            frmInterno.TopLevel = false;
            frmInterno.FormBorderStyle = FormBorderStyle.None;
            frmInterno.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(frmInterno);
            panelContenedor.Tag = frmInterno;
            frmInterno.BringToFront();
            frmInterno.Show();
        }
        private void cargarGrid()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                ListaArticulos = negocio.listar();
                dgvArticulos.DataSource = ListaArticulos;
                dgvArticulos.Columns["ID"].Visible = false;
                dgvArticulos.Columns["ImagenUrl"].Visible = false;
                dgvArticulos.Columns["Categoria"].Visible = false;
                dgvArticulos.Columns["Marca"].Visible = false;
                dgvArticulos.Columns["Descripcion"].Visible = false;
                dgvArticulos.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmInterno(new frmAgregarModificar());
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmInterno(new frmAgregarModificar(articuloSeleccionado));
            }
            else
            {
                MessageBox.Show("Debe seleccionar un artículo de la lista.","Modificar");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                if (MessageBox.Show("¿Desea eliminar el artículo seleccionado?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Artículo eliminado correctamente.");

                    ArticuloNegocio obj = new ArticuloNegocio();
                    Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    obj.eliminar(articuloSeleccionado);
                    cargarGrid();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un artículo de la lista.","Eliminar");
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmInterno(new frmBuscar());
        }
        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmInterno(new frmVerDetalle(articuloSeleccionado));
            }
            else
            {
                MessageBox.Show("Debe seleccionar un artículo de la lista.","Ver detalle");
            }
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }
    }
}
