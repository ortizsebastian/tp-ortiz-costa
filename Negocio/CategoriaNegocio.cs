using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("Select distinct Id, Descripcion From CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria obj = new Categoria();
                    obj.Id = (int)datos.Lector["Id"];
                    obj.Descripcion = (string)datos.Lector["Descripcion"];

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

