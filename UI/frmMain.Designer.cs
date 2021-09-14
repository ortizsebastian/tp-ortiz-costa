
namespace UI
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
            this.menuArticulos = new System.Windows.Forms.MenuStrip();
            this.tsmi_listarArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_agregarArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_eliminarArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_verArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArticulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuArticulos
            // 
            this.menuArticulos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_listarArticulos,
            this.tsmi_agregarArticulos,
            this.tsmi_eliminarArticulos,
            this.tsmi_verArticulo});
            this.menuArticulos.Location = new System.Drawing.Point(0, 0);
            this.menuArticulos.Name = "menuArticulos";
            this.menuArticulos.Size = new System.Drawing.Size(524, 27);
            this.menuArticulos.TabIndex = 4;
            this.menuArticulos.Text = "menuStrip1";
            // 
            // tsmi_listarArticulos
            // 
            this.tsmi_listarArticulos.Name = "tsmi_listarArticulos";
            this.tsmi_listarArticulos.Size = new System.Drawing.Size(111, 23);
            this.tsmi_listarArticulos.Text = "Listar Artículos";
            this.tsmi_listarArticulos.Click += new System.EventHandler(this.tsmi_listarArticulos_Click);
            // 
            // tsmi_agregarArticulos
            // 
            this.tsmi_agregarArticulos.Name = "tsmi_agregarArticulos";
            this.tsmi_agregarArticulos.Size = new System.Drawing.Size(70, 23);
            this.tsmi_agregarArticulos.Text = "Agregar";
            this.tsmi_agregarArticulos.Click += new System.EventHandler(this.tsmi_agregarArticulos_Click);
            // 
            // tsmi_eliminarArticulos
            // 
            this.tsmi_eliminarArticulos.Name = "tsmi_eliminarArticulos";
            this.tsmi_eliminarArticulos.Size = new System.Drawing.Size(69, 23);
            this.tsmi_eliminarArticulos.Text = "Eliminar";
            this.tsmi_eliminarArticulos.Click += new System.EventHandler(this.tsmi_eliminarArticulos_Click);
            // 
            // tsmi_verArticulo
            // 
            this.tsmi_verArticulo.Name = "tsmi_verArticulo";
            this.tsmi_verArticulo.Size = new System.Drawing.Size(92, 23);
            this.tsmi_verArticulo.Text = "Ver Artículo";
            this.tsmi_verArticulo.Click += new System.EventHandler(this.tsmi_verArticulo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 285);
            this.Controls.Add(this.menuArticulos);
            this.MainMenuStrip = this.menuArticulos;
            this.Name = "frmMain";
            this.Text = "Gestión de Artículos";
            this.menuArticulos.ResumeLayout(false);
            this.menuArticulos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.MenuStrip menuArticulos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_listarArticulos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_agregarArticulos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_eliminarArticulos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_verArticulo;
    }
}

