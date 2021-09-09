using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace tp_winforms_catalogo
{
    public class ConexionSqlAgregar
    {
        public static int Agregar(Articulo pArticulo)
        {
            int retorno = 0;
            using (SqlConnection Conn = CreaConexion.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("insert into ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) " +
                    "values('{0}', '{1}', '{2}','{3}', '{4}', '{5}', '{6}')",
                    pArticulo.Codigo, pArticulo.Nombre, pArticulo.Descripcion, pArticulo.IdMarca, pArticulo.IdCategoria, pArticulo.ImagenUrl, pArticulo.Precio), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
