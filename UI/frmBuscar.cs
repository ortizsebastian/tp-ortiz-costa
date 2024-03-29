﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Dominio;
using Negocio;

namespace UI
{
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio aux = new ArticuloNegocio();
            Articulo obj = new Articulo();

            try
            {
                if(txtId.Text != "")
                {
                    obj.Id = int.Parse(txtId.Text);
                }
                obj.Nombre = txtNombre.Text;
                obj.Codigo = txtCodigo.Text;

                dgvBuscar.DataSource = aux.buscar(obj);
                if (dgvBuscar.Rows.Count == 0)
                    dgvBuscar.Columns.Clear();
                else
                    dgvBuscar.Columns["ImagenUrl"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
