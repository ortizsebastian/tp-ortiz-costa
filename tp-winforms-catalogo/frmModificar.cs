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
    public partial class frmModificar : Form
    {
        public frmModificar()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmMain to = new frmMain();
            to.Show();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //int Precio = Int32.Parse(txtModificarPrecio.Text);

                Articulo pArticulo = new Articulo();
                pArticulo.Codigo = txtModificarCodigo.Text;
                pArticulo.Nombre = txtModificarNombre.Text;
                pArticulo.Descripcion = txtModificarDescripcion.Text;
                pArticulo.IdMarca = txtModificarMarca.Text;
                pArticulo.IdCategoria = txtModificarCategoria.Text;
                pArticulo.ImagenUrl = txtModificarUrl.Text;
                pArticulo.Precio = int.Parse(txtModificarPrecio.Text);

                int resultado = ConexionSqlAgregar.modificar(pArticulo);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos modificados correctamente", "Datos modificados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron modificar los datos", "Error al modificar datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void limpiar()
        {
            txtModificarCodigo.Clear();
            txtModificarNombre.Clear();
            txtModificarDescripcion.Clear();
            txtModificarMarca.Clear();
            txtModificarCategoria.Clear();
            txtModificarUrl.Clear();
            txtModificarPrecio.Clear();
        }
    }
}
