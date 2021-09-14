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
        public List<Articulo> Listar()
        {
            List<Articulo> Lista = new List<Articulo>();
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetConsulta("Select distinct Codigo as Código, Nombre,  ImagenUrl, A.Descripcion as Descripción, C.Descripcion as Categoría, M.Descripcion as Marca From ARTICULOS A, MARCAS M, CATEGORIAS C Where A.IdCategoria = C.Id and A.IdMarca = M.Id order by Nombre asc");
                Datos.EjecutarLectura();

                while (Datos.Lector.Read())
                {
                    Articulo Auxiliar = new Articulo();
                    Auxiliar.Codigo = (string)Datos.Lector["Código"];
                    Auxiliar.Nombre = (string)Datos.Lector["Nombre"];
                    Auxiliar.Descripcion = (string)Datos.Lector["Descripción"];
                    Auxiliar.ImagenUrl = (string)Datos.Lector["ImagenUrl"];

                    Auxiliar.Categoria = new Categoria();
                    Auxiliar.Categoria.Descripcion = (string)Datos.Lector["Categoría"];
                    Auxiliar.Marca = new Marca();
                    Auxiliar.Marca.Descripcion = (string)Datos.Lector["Marca"];

                    Lista.Add(Auxiliar);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }

        public void agregar(Articulo nuevoArticulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, ImagenUrl, Precio, IdCategoria, IdMarca) values ('" + nuevoArticulo.Codigo + "', '" + nuevoArticulo.Nombre + "', " +
                    "'" + nuevoArticulo.Descripcion + "', '" + nuevoArticulo.ImagenUrl + "', '" + nuevoArticulo.Precio + "', '" + nuevoArticulo.Categoria.Id + "', '" + nuevoArticulo.Marca.Id + "')");
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void modificar(Articulo modificarArticulo)
        {

        }
    }
}
