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
        private Articulo articuloSeleccion = null;
        public frmAgregarModificar()
        {
            InitializeComponent();
        }
        public frmAgregarModificar(Articulo articuloSeleccionado)
        {
            InitializeComponent();
            this.articuloSeleccion = articuloSeleccionado;
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

                if (articuloSeleccion != null)
                {
                    txtCodigo.Text = articuloSeleccion.Codigo;
                    txtNombre.Text = articuloSeleccion.Nombre;
                    txtDescripcion.Text = articuloSeleccion.Descripcion;
                    txtImagen.Text = articuloSeleccion.ImagenUrl;
                    cargarImagen(articuloSeleccion.ImagenUrl);
                    txtPrecio.Text = articuloSeleccion.Precio.ToString();
                    cboCategoria.SelectedValue = articuloSeleccion.Categoria.Id;
                    cboMarca.SelectedValue = articuloSeleccion.Marca.Id;

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

        void limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtImagen.Clear();
            txtPrecio.Clear();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                ArticuloNegocio negocio = new ArticuloNegocio();

                try
                {
                    if (articuloSeleccion == null)
                        articuloSeleccion = new Articulo();

                    articuloSeleccion.Codigo = txtCodigo.Text;
                    articuloSeleccion.Nombre = txtNombre.Text;
                    articuloSeleccion.Descripcion = txtDescripcion.Text;
                    articuloSeleccion.ImagenUrl = txtImagen.Text;
                    articuloSeleccion.Precio = int.Parse(txtPrecio.Text);
                    articuloSeleccion.Marca = (Marca)cboMarca.SelectedItem;
                    articuloSeleccion.Categoria = (Categoria)cboCategoria.SelectedItem;

                    if (articuloSeleccion.Id != 0)
                    {
                        negocio.modificar(articuloSeleccion);
                        MessageBox.Show("Datos modificados correctamente.", "Datos modificados.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        negocio.agregar(articuloSeleccion);
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
