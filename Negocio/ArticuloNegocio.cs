using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;


namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("SELECT A.Nombre, A.ImagenUrl, A.Codigo AS Código, A.Descripcion AS Descripción, C.Descripcion AS Categoría, M.Descripcion AS Marca FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id ORDER BY Nombre ASC");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo obj = new Articulo();
                    obj.Codigo = (string)datos.Lector["Código"];
                    obj.Nombre = (string)datos.Lector["Nombre"];
                    obj.Descripcion = (string)datos.Lector["Descripción"];

                    if(!(datos.Lector["ImagenUrl"] is DBNull))
                        obj.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    obj.Categoria = new Categoria();
                    if (!(datos.Lector["Categoría"] is DBNull))
                        obj.Categoria.Descripcion = (string)datos.Lector["Categoría"];
                    else obj.Categoria.Descripcion = "Desconocida";
                    obj.Marca = new Marca();
                    if (!(datos.Lector["Marca"] is DBNull))
                        obj.Marca.Descripcion = (string)datos.Lector["Marca"];
                    else
                        obj.Marca.Descripcion = "Desconocida";
                    lista.Add(obj);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Articulo nuevoArticulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, ImagenUrl, Precio, IdCategoria, IdMarca) values ('" + nuevoArticulo.Codigo + "', '" + nuevoArticulo.Nombre + "', " +
                    "'" + nuevoArticulo.Descripcion + "', '" + nuevoArticulo.ImagenUrl + "', '" + nuevoArticulo.Precio + "', '" + nuevoArticulo.Categoria.Id + "', '" + nuevoArticulo.Marca.Id + "')");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Modificar(Articulo modificarArticulo)
        {

        }
    }
}
