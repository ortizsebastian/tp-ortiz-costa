
namespace tp_winforms_catalogo
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tsmi1_listarArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi2_modificarArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi3_agregarArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi4_eliminarArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi5_verArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArticulos = new System.Windows.Forms.MenuStrip();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.menuArticulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsmi1_listarArticulos
            // 
            this.tsmi1_listarArticulos.Name = "tsmi1_listarArticulos";
            this.tsmi1_listarArticulos.Size = new System.Drawing.Size(97, 20);
            this.tsmi1_listarArticulos.Text = "Listar Artículos";
            this.tsmi1_listarArticulos.Click += new System.EventHandler(this.tsmi1_listarArticulos_Click);
            // 
            // tsmi2_modificarArticulos
            // 
            this.tsmi2_modificarArticulos.Name = "tsmi2_modificarArticulos";
            this.tsmi2_modificarArticulos.Size = new System.Drawing.Size(70, 20);
            this.tsmi2_modificarArticulos.Text = "Modificar";
            this.tsmi2_modificarArticulos.Click += new System.EventHandler(this.tsmi2_modificarArticulos_Click);
            // 
            // tsmi3_agregarArticulos
            // 
            this.tsmi3_agregarArticulos.Name = "tsmi3_agregarArticulos";
            this.tsmi3_agregarArticulos.Size = new System.Drawing.Size(61, 20);
            this.tsmi3_agregarArticulos.Text = "Agregar";
            this.tsmi3_agregarArticulos.Click += new System.EventHandler(this.tsmi3_agregarArticulos_Click);
            // 
            // tsmi4_eliminarArticulos
            // 
            this.tsmi4_eliminarArticulos.Name = "tsmi4_eliminarArticulos";
            this.tsmi4_eliminarArticulos.Size = new System.Drawing.Size(62, 20);
            this.tsmi4_eliminarArticulos.Text = "Eliminar";
            this.tsmi4_eliminarArticulos.Click += new System.EventHandler(this.tsmi4_eliminarArticulos_Click);
            // 
            // tsmi5_verArticulo
            // 
            this.tsmi5_verArticulo.Name = "tsmi5_verArticulo";
            this.tsmi5_verArticulo.Size = new System.Drawing.Size(80, 20);
            this.tsmi5_verArticulo.Text = "Ver Artículo";
            this.tsmi5_verArticulo.Click += new System.EventHandler(this.tsmi5_verArticulo_Click);
            // 
            // busquedaDeArticulosToolStripMenuItem
            // 
            this.busquedaDeArticulosToolStripMenuItem.Name = "busquedaDeArticulosToolStripMenuItem";
            this.busquedaDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.busquedaDeArticulosToolStripMenuItem.Text = "Busqueda De Articulos";
            // 
            // menuArticulos
            // 
            this.menuArticulos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi1_listarArticulos,
            this.tsmi2_modificarArticulos,
            this.tsmi3_agregarArticulos,
            this.tsmi4_eliminarArticulos,
            this.tsmi5_verArticulo,
            this.busquedaDeArticulosToolStripMenuItem});
            this.menuArticulos.Location = new System.Drawing.Point(0, 0);
            this.menuArticulos.Name = "menuArticulos";
            this.menuArticulos.Size = new System.Drawing.Size(524, 24);
            this.menuArticulos.TabIndex = 4;
            this.menuArticulos.Text = "menuStrip1";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(211, 243);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 285);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.menuArticulos);
            this.MainMenuStrip = this.menuArticulos;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Artículos";
            this.menuArticulos.ResumeLayout(false);
            this.menuArticulos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tsmi1_listarArticulos;
        private System.Windows.Forms.ToolStripMenuItem tsmi2_modificarArticulos;
        private System.Windows.Forms.ToolStripMenuItem tsmi3_agregarArticulos;
        private System.Windows.Forms.ToolStripMenuItem tsmi4_eliminarArticulos;
        private System.Windows.Forms.ToolStripMenuItem tsmi5_verArticulo;
        private System.Windows.Forms.ToolStripMenuItem busquedaDeArticulosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuArticulos;
        private System.Windows.Forms.Button btnCerrar;
    }
}

