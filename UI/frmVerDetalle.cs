using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace UI
{
    public partial class frmVerDetalle : Form
    {
        private Articulo articuloSeleccionado = null;
        public frmVerDetalle()
        {
            InitializeComponent();
        }
        public frmVerDetalle(Articulo articuloSeleccionado)
        {
            InitializeComponent();
            this.articuloSeleccionado = articuloSeleccionado;
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
        private void frmVerDetalle_Load(object sender, EventArgs e)
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            listaArticulos.Add(articuloSeleccionado);
            dgvArticulosDetalle.DataSource = listaArticulos;
            dgvArticulosDetalle.Columns["ImagenUrl"].Visible = false;
            cargarImagen(listaArticulos[0].ImagenUrl);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}





