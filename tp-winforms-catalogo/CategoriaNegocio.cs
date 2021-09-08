using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace tp_winforms_catalogo
{
    class CategoriaNegocio
    {
        public List<Categoria> listar() //es un metodo del tipo lista, por ende retornara una lista (de Categorias)
        {
            List<Categoria> lista = new List<Categoria>(); //se crea la lista
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector; //no tiene constructor la clase del objeto

            try 
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Descripcion From CATEGORIAS";
                comando.Connection = conexion; //repasar esta linea

                conexion.Open();
                lector = comando.ExecuteReader(); //dentro del obj SqlDataReader se guarda el comando a realizar

                while (lector.Read()) //se ejecuta la lectura
                {
                    Categoria aux = new Categoria(); //crea un obj aux en el cual se ira guardando los atributos
                    aux.Id = (int)lector["Id"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    lista.Add(aux); //se guarda el obj en una lista
                }
                conexion.Close(); //se cierra la conexion
                return lista; //el metodo finalmente retornara la lista al ser llamado
            }
            catch (Exception ex) //manejo de excepciones
            {
                throw ex;
            }
        }
    }
}
