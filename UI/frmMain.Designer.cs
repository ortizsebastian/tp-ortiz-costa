
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
            this.tsmi_modificarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulos = new System.Windows.Forms.PictureBox();
            this.menuArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuArticulos
            // 
            this.menuArticulos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_listarArticulos,
            this.tsmi_agregarArticulos,
            this.tsmi_modificarArticulo,
            this.tsmi_eliminarArticulos,
            this.tsmi_verArticulo});
            this.menuArticulos.Location = new System.Drawing.Point(0, 0);
            this.menuArticulos.Name = "menuArticulos";
            this.menuArticulos.Size = new System.Drawing.Size(859, 24);
            this.menuArticulos.TabIndex = 4;
            this.menuArticulos.Text = "menuStrip1";
            // 
            // tsmi_listarArticulos
            // 
            this.tsmi_listarArticulos.Name = "tsmi_listarArticulos";
            this.tsmi_listarArticulos.Size = new System.Drawing.Size(12, 20);
            // 
            // tsmi_agregarArticulos
            // 
            this.tsmi_agregarArticulos.Name = "tsmi_agregarArticulos";
            this.tsmi_agregarArticulos.Size = new System.Drawing.Size(61, 20);
            this.tsmi_agregarArticulos.Text = "Agregar";
            this.tsmi_agregarArticulos.Click += new System.EventHandler(this.tsmi_agregarArticulos_Click);
            // 
            // tsmi_eliminarArticulos
            // 
            this.tsmi_eliminarArticulos.Name = "tsmi_eliminarArticulos";
            this.tsmi_eliminarArticulos.Size = new System.Drawing.Size(62, 20);
            this.tsmi_eliminarArticulos.Text = "Eliminar";
            this.tsmi_eliminarArticulos.Click += new System.EventHandler(this.tsmi_eliminarArticulos_Click);
            // 
            // tsmi_verArticulo
            // 
            this.tsmi_verArticulo.Name = "tsmi_verArticulo";
            this.tsmi_verArticulo.Size = new System.Drawing.Size(80, 20);
            this.tsmi_verArticulo.Text = "Ver Artículo";
            this.tsmi_verArticulo.Click += new System.EventHandler(this.tsmi_verArticulo_Click);
            // 
            // tsmi_modificarArticulo
            // 
            this.tsmi_modificarArticulo.Name = "tsmi_modificarArticulo";
            this.tsmi_modificarArticulo.Size = new System.Drawing.Size(70, 20);
            this.tsmi_modificarArticulo.Text = "Modificar";
            this.tsmi_modificarArticulo.Click += new System.EventHandler(this.tsmi_modificarArticulo_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 41);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(557, 238);
            this.dgvArticulos.TabIndex = 5;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxArticulos
            // 
            this.pbxArticulos.Location = new System.Drawing.Point(588, 41);
            this.pbxArticulos.Name = "pbxArticulos";
            this.pbxArticulos.Size = new System.Drawing.Size(251, 238);
            this.pbxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulos.TabIndex = 6;
            this.pbxArticulos.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 313);
            this.Controls.Add(this.pbxArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.menuArticulos);
            this.MainMenuStrip = this.menuArticulos;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Artículos";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuArticulos.ResumeLayout(false);
            this.menuArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.MenuStrip menuArticulos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_listarArticulos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_agregarArticulos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_eliminarArticulos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_verArticulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_modificarArticulo;
    }
}

