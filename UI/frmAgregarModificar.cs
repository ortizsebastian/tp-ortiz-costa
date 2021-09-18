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
    public partial class frmAgregarModificar : Form
    {
        private Articulo articuloSeleccionado = null;
        public frmAgregarModificar()
        {
            InitializeComponent();
        }
        public frmAgregarModificar(Articulo articuloSeleccionado)
        {
            InitializeComponent();
            this.articuloSeleccionado = articuloSeleccionado;
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            CategoriaNegocio catNegocio = new CategoriaNegocio();
            MarcaNegocio marNegocio = new MarcaNegocio();

            try
            {
                cboCategoria.DataSource = catNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboMarca.DataSource = marNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                if (articuloSeleccionado != null)
                {
                    txtCodigo.Text = articuloSeleccionado.Codigo;
                    txtNombre.Text = articuloSeleccionado.Nombre;
                    txtDescripcion.Text = articuloSeleccionado.Descripcion;
                    txtImagen.Text = articuloSeleccionado.ImagenUrl;
                    cargarImagen(articuloSeleccionado.ImagenUrl);
                    txtPrecio.Text = articuloSeleccionado.Precio.ToString();
                    cboCategoria.SelectedValue = articuloSeleccionado.Categoria.Id;
                    cboMarca.SelectedValue = articuloSeleccionado.Marca.Id;
                }
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
                pbxVistaPrevia.Load(imagen);
            }
            catch (Exception)
            {
                pbxVistaPrevia.Load("https://www.salonlfc.com/wp-content/uploads/2018/01/image-not-found-scaled-1150x647.png");
            }
        }
        private void limpiar()
                {
                    txtCodigo.Clear();
                    txtNombre.Clear();
                    txtDescripcion.Clear();
                    txtImagen.Clear();
                    txtPrecio.Clear();
                }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                try
                {
                    if (articuloSeleccionado == null)
                        articuloSeleccionado = new Articulo();

                    articuloSeleccionado.Codigo = txtCodigo.Text;
                    articuloSeleccionado.Nombre = txtNombre.Text;
                    articuloSeleccionado.Descripcion = txtDescripcion.Text;
                    articuloSeleccionado.ImagenUrl = txtImagen.Text;
                    articuloSeleccionado.Precio = int.Parse(txtPrecio.Text);
                    articuloSeleccionado.Marca = (Marca)cboMarca.SelectedItem;
                    articuloSeleccionado.Categoria = (Categoria)cboCategoria.SelectedItem;

                    if (articuloSeleccionado.Id != 0)
                    {
                        negocio.modificar(articuloSeleccionado);
                        MessageBox.Show("Datos modificados correctamente.", "Datos modificados.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        negocio.agregar(articuloSeleccionado);
                        MessageBox.Show("Datos agregados correctamente.", "Datos agregados.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error al intentar agregar o modificar datos.", "Error al modificar o agregar datos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
