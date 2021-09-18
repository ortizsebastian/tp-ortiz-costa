using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace UI
{
    public partial class frmMain : Form
    {
        private List<Articulo> ListaArticulos;
        private Articulo ArticuloSeleccionado;
        public frmMain()
        {
            InitializeComponent();
        }

        //Panel
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

        //Metodos Custom
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        //Botones del Menu Principal
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmInterno(new frmAgregarModificar());
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo ArticuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmInterno(new frmAgregarModificar(ArticuloSeleccionado));
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmInterno(new frmEliminar());
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmInterno(new frmBuscar());
        }
        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo ArticuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmInterno(new frmVerDetalle(ArticuloSeleccionado));
            }
        }

        //Eventos de Carga
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            ArticuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }
    }
}
