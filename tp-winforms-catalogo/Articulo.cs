using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_winforms_catalogo
{
    public class Articulo
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string IdMarca { get; set; }
        public string IdCategoria { get; set; }
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; }

        public Articulo() { }

        public Articulo(string pCodigo, string pNombre, string pDescripcion, string pIdMarca, string pIdCategoria, string pImagenUrl, decimal pPrecio)
        {
            this.Codigo = pCodigo;
            this.Nombre = pNombre;
            this.Descripcion = pDescripcion;
            this.IdMarca = pIdMarca;
            this.IdCategoria = pIdCategoria;
            this.ImagenUrl = pImagenUrl;
            this.Precio = pPrecio;
        }





    }

}
