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
            List<Categoria> Lista = new List<Categoria>();
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetConsulta("Select distinct Id, Descripcion From CATEGORIAS");
                Datos.EjecutarLectura();

                while (Datos.Lector.Read())
                {
                    Categoria Auxiliar = new Categoria();
                    Auxiliar.Id = (int)Datos.Lector["Id"];
                    Auxiliar.Descripcion = (string)Datos.Lector["Descripcion"];

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

