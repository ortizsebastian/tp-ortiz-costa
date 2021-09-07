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
    public partial class Form1 : Form
    {
        private List<Articulo> ListaProductos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ListaProductos = negocio.listar();
            dgvArticulos.DataSource = ListaProductos;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            cargarImagen(ListaProductos[0].ImagenUrl);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo Seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(Seleccionado.ImagenUrl);
        }
        
        private void cargarImagen(string imagen)
        { 
            try
            {
                PbElectro.Load(imagen);
            }
            catch (Exception ex)
            {
                PbElectro.Load("https://www.salonlfc.com/wp-content/uploads/2018/01/image-not-found-scaled-1150x647.png");
            }
        }
    }
}
