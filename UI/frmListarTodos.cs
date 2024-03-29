﻿using System;
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
    public partial class frmListarTodos : Form
    {
        private List<Articulo> ListaArticulos;
        public frmListarTodos()
        {
            InitializeComponent();
        }
        private void frmListarTodos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio Negocio = new ArticuloNegocio();
            ListaArticulos = Negocio.Listar();
            dgvArticulos.DataSource = ListaArticulos;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            CargarImagen(ListaArticulos[0].ImagenUrl);
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo Seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            CargarImagen(Seleccionado.ImagenUrl);
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
