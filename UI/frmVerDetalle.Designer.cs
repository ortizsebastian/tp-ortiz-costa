
namespace UI
{
    partial class frmVerDetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticulosDetalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulosDetalle
            // 
            this.dgvArticulosDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosDetalle.Location = new System.Drawing.Point(13, 13);
            this.dgvArticulosDetalle.Name = "dgvArticulosDetalle";
            this.dgvArticulosDetalle.Size = new System.Drawing.Size(744, 60);
            this.dgvArticulosDetalle.TabIndex = 0;
            // 
            // frmVerDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 88);
            this.Controls.Add(this.dgvArticulosDetalle);
            this.Name = "frmVerDetalle";
            this.Text = "Detalle del Artículo";
            this.Load += new System.EventHandler(this.frmVerDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulosDetalle;
    }
}