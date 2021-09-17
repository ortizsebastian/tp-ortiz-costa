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
        private void frmMain_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;            
            cargarImagen(seleccionado.ImagenUrl);
        }
        private Form activeForm = null;
        private void subMenu(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            subMenu(new frmVerDetalle(seleccionado));
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            subMenu(new frmAgregarModificar());
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            subMenu(new frmAgregarModificar(seleccionado));
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            subMenu(new frmEliminar());
        }
    }
}
