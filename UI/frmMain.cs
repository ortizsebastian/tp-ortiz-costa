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
        public frmMain()
        {
            InitializeComponent();
        }
        private void tsmi_agregarArticulos_Click(object sender, EventArgs e)
        {
            frmAgregar AgregarArticulo = new frmAgregar();
            AgregarArticulo.ShowDialog();
            cargarAuto();
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

        private List<Articulo> ListaArticulos;
        private void frmMain_Load(object sender, EventArgs e)
        {
            cargarAuto();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo Seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            CargarImagen(Seleccionado.ImagenUrl);
        }

        private void cargarAuto()
        {
            ArticuloNegocio Negocio = new ArticuloNegocio();

            ListaArticulos = Negocio.Listar();
            dgvArticulos.DataSource = ListaArticulos;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            CargarImagen(ListaArticulos[0].ImagenUrl);
        }

        private void CargarImagen(string imagen)
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
