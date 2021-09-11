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

        public static List<Articulo> buscarArticulo(String pCodigo)
        {
            List<Articulo> Lista = new List<Articulo>();
            using(SqlConnection conexion = CreaConexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("select distinct Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio from ARTICULOS " +
                    "where Codigo like '%{0}%'", pCodigo),conexion);
                
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Articulo pArticulo = new Articulo();
                    pArticulo.Codigo = reader.GetString(0);
                    pArticulo.Nombre = reader.GetString(1);
                    pArticulo.Descripcion = reader.GetString(2);
                    //pArticulo.IdMarca = Convert.ToString(reader.GetString(3));
                    //pArticulo.IdCategoria = Convert.ToString(reader.GetString(4));
                    pArticulo.ImagenUrl = reader.GetString(5);
                    pArticulo.Precio = reader.GetDecimal(6);

                    Lista.Add(pArticulo);
                }
                conexion.Close();
                return Lista;
            }  
        }

        public static int modificar(Articulo pArticulo)
        {
            int retorno = 0;
            using(SqlConnection conexion = CreaConexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("update ARTICULOS set Codigo='{0}', Nombre='{1}', Descripcion='{2}', IdMarca='{3}', IdCategoria='{4}', " +
                    "ImagenUrl='{5}', Precio='{6}' where Codigo = '{0}'", pArticulo.Codigo, pArticulo.Nombre, pArticulo.Descripcion, pArticulo.IdMarca, pArticulo.IdCategoria,
                    pArticulo.ImagenUrl, pArticulo.Precio), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }

        public static int eliminar (string Codigo)
        {
            int retorno = 0;
            using (SqlConnection conexion = CreaConexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("delete from ARTICULOS where Codigo = '{0}'", Codigo), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
    }
}
