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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                int Precio = Int32.Parse(txtPrecio.Text);

                Articulo Articulo = new Articulo();
                Articulo.Codigo = txtCodigo.Text;
                Articulo.Nombre = txtNombre.Text;
                Articulo.Descripcion = txtDescripcion.Text;
                Articulo.IdMarca = txtIdMarca.Text;
                Articulo.IdCategoria = txtIdCategoria.Text;
                Articulo.ImagenUrl = txtUrl.Text;
                Articulo.Precio = Precio;

                int resultado = ConexionSqlAgregar.Agregar(Articulo);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos guardados correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron guardar los datos", "Error al guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmMain to = new frmMain();
            to.Show();
            this.Close();
        }

        void limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtIdMarca.Clear();
            txtIdCategoria.Clear();
            txtUrl.Clear();
            txtPrecio.Clear();
        }
    }
}
