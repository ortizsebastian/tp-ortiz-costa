using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("Select Id, Descripcion From MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca obj = new Marca();
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

