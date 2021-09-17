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
        private Articulo articuloSeleccion = null;

        public frmVerDetalle(Articulo articuloSeleccion)
        {
            InitializeComponent();
            this.articuloSeleccion = articuloSeleccion;
        }
        private void frmVerDetalle_Load(object sender, EventArgs e)
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            listaArticulos.Add(articuloSeleccion);
            dgvArticulosDetalle.DataSource = listaArticulos;
            dgvArticulosDetalle.Columns["ImagenUrl"].Visible = false;
        }
    }
}
