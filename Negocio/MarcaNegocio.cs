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
        public List<Marca> Listar()
        {
            List<Marca> Lista = new List<Marca>();
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetConsulta("Select Id, Descripcion From MARCAS");
                Datos.EjecutarLectura();

                while (Datos.Lector.Read())
                {
                    Marca Axuliar = new Marca();
                    Axuliar.Id = (int)Datos.Lector["Id"];
                    Axuliar.Descripcion = (string)Datos.Lector["Descripcion"];

                    Lista.Add(Axuliar);
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

