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
                Datos.SetConsulta("Select distinct Codigo, Nombre, Descripcion, ImagenUrl From ARTICULOS order by Nombre asc");
                Datos.EjecutarLectura();

                while (Datos.Lector.Read())
                {
                    Articulo Auxiliar = new Articulo();
                    Auxiliar.Codigo = (string)Datos.Lector["Codigo"];
                    Auxiliar.Nombre = (string)Datos.Lector["Nombre"];
                    Auxiliar.Descripcion = (string)Datos.Lector["Descripcion"];
                    Auxiliar.ImagenUrl = (string)Datos.Lector["ImagenUrl"];
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
    }
}
