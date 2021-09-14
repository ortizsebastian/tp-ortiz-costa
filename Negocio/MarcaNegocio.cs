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
            AccesoAdatos datos = new AccesoAdatos();

            try
            {
                datos.SetConsulta("Select Id, Descripcion From MARCAS");
                datos.EjLectura();

                while (datos.Lector.Read()) 
                {
                    Marca aux = new Marca(); 
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux); 
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
