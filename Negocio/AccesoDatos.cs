using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection Conexion;

        private SqlCommand Comando;
        public SqlDataReader Lector { get; set; }
        public AccesoDatos()
        {
            Conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
            Comando = new SqlCommand();
        }
        public void setConsulta(string consulta)
        {
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = consulta;
        }
        public void ejecutarLectura()
        {
            Comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                Lector = Comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ejecutarAccion()
        {
            Comando.Connection = Conexion;

            try
            {
                Conexion.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void setearParametro(string nombre, object valor)
        {
            Comando.Parameters.AddWithValue("nombre", valor);
        }
        public void cerrarConexion()
        {
            if (Lector != null) Lector.Close();
            Conexion.Close();
        }
    }
}
