using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace UI
{
    public partial class frmMain : Form
    {
        private List<Articulo> ListaArticulos;
        public frmMain()
        {
            InitializeComponent();
        }
        private void tsmi_agregarArticulos_Click(object sender, EventArgs e)
        {
            frmAgregarModificar agregarArticulo = new frmAgregarModificar();
            agregarArticulo.ShowDialog();
            cargarAuto();
        }
        private void tsmi_eliminarArticulos_Click(object sender, EventArgs e)
        {
            frmEliminar eliminarArticulo = new frmEliminar();
            eliminarArticulo.ShowDialog();
        }
        private void tsmi_verArticulo_Click(object sender, EventArgs e)
        {
            frmListar listar = new frmListar();
            listar.ShowDialog();
        }
        private void tsmi_modificarArticulo_Click(object sender, EventArgs e)
        {
            frmAgregarModificar modificarArticulo = new frmAgregarModificar();
            modificarArticulo.Text = "Modificar Artículo";
            modificarArticulo.ShowDialog();
            cargarAuto();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            cargarAuto();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
        }

        private void cargarAuto()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                ListaArticulos = negocio.listar();
                dgvArticulos.DataSource = ListaArticulos;
                dgvArticulos.Columns["ImagenUrl"].Visible = false;
                cargarImagen(ListaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulos.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulos.Load("https://www.salonlfc.com/wp-content/uploads/2018/01/image-not-found-scaled-1150x647.png");
            }
        }
    }
}
