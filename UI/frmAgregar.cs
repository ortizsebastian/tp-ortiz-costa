using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;
using System.Windows.Forms;

namespace UI
{
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                nuevo.Codigo = txtCodigo.Text;
                nuevo.Nombre = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.ImagenUrl = txtImagen.Text;
                nuevo.Precio = int.Parse(txtPrecio.Text);
                nuevo.Marca = (Marca)cboMarca.SelectedItem;
                nuevo.Categoria = (Categoria)cboCategoria.SelectedItem;

                negocio.agregar(nuevo);
                MessageBox.Show("Agregado exitosamente");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            CategoriaNegocio catNegocio = new CategoriaNegocio();
            MarcaNegocio marNegocio = new MarcaNegocio();

            try
            {
                cboCategoria.DataSource = catNegocio.listar();
                cboMarca.DataSource = marNegocio.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxVistaPrecia.Load(imagen);
            }
            catch (Exception)
            {
                pbxVistaPrecia.Load("https://www.salonlfc.com/wp-content/uploads/2018/01/image-not-found-scaled-1150x647.png");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
