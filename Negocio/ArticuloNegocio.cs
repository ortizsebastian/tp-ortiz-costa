using System;
using System.Collections.Generic;
using Dominio;

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
                datos.setConsulta("SELECT A.Id AS Id, A.Nombre, A.ImagenUrl, A.Precio, A.Codigo AS Código, A.Descripcion AS Descripción, A.IdCategoria, A.IdMarca, C.Descripcion AS Categoría, M.Descripcion AS Marca FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id ORDER BY Nombre ASC");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo obj = new Articulo();
                    obj.Id = (int)datos.Lector["ID"];
                    obj.Codigo = (string)datos.Lector["Código"];
                    obj.Nombre = (string)datos.Lector["Nombre"];
                    obj.Descripcion = (string)datos.Lector["Descripción"];
                    obj.Precio = (decimal)datos.Lector["Precio"];

                    if(!(datos.Lector["ImagenUrl"] is DBNull))
                        obj.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    obj.Categoria = new Categoria();
                    obj.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    if (!(datos.Lector["Categoría"] is DBNull))
                        obj.Categoria.Descripcion = (string)datos.Lector["Categoría"];
                    else obj.Categoria.Descripcion = "Desconocida";
                    obj.Marca = new Marca();
                    obj.Marca.Id = (int)datos.Lector["IdMarca"];
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
        public void modificar(Articulo modificarArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("UPDATE ARTICULOS set Codigo = '" + modificarArticulo.Codigo + "', Nombre = '" + modificarArticulo.Nombre + "', " +
                "Descripcion = '" + modificarArticulo.Descripcion + "', IdCategoria = '" + modificarArticulo.Categoria.Id + "', " +
                "IdMarca = '" + modificarArticulo.Marca.Id + "', ImagenUrl = '" + modificarArticulo.ImagenUrl + "', Precio = '" + modificarArticulo.Precio + "' " +
                "where Id = '" + modificarArticulo.Id + "'");

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
        public void eliminar(Articulo eliminarArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("DELETE ARTICULOS WHERE Id = '" + eliminarArticulo.Id + "'");
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
        public List<Articulo> buscar(Articulo buscarArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Articulo> lista = new List<Articulo>();

            try
            {
                datos.setConsulta("SELECT A.Id, A.Nombre, A.ImagenUrl, A.Precio, A.Codigo AS Código, A.Descripcion AS Descripción, A.IdCategoria, A.IdMarca, C.Descripcion AS Categoría, M.Descripcion AS Marca FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id WHERE A.Id = '" + buscarArticulo.Id + "' OR A.Codigo = '" + buscarArticulo.Codigo + "' OR A.Nombre = '" + buscarArticulo.Nombre + "'");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo obj = new Articulo();
                    obj.Id = (int)datos.Lector["Id"];
                    obj.Codigo = (string)datos.Lector["Codigo"];
                    obj.Nombre = (string)datos.Lector["Nombre"];
                    obj.Descripcion = (string)datos.Lector["Descripcion"];
                    obj.Precio = (decimal)datos.Lector["Precio"];

                    obj.Categoria = new Categoria();
                    if (!(datos.Lector["Categoria"] is DBNull))
                        obj.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    else 
                        obj.Categoria.Descripcion = "Desconocida";
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
    }
}
