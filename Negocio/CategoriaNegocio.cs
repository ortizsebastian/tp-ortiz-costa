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
            AccesoAdatos datos = new AccesoAdatos();

            try
            {
                datos.SetConsulta("Select distinct Id, Descripcion From CATEGORIAS");
                datos.EjLectura();

                while (datos.Lector.Read()) 
                {
                    Categoria aux = new Categoria();
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
