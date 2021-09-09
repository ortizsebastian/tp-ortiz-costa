using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace tp_winforms_catalogo
{
    public class CreaConexion
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conn = new SqlConnection("Data source = .\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
            Conn.Open();

            return Conn;
        }
    }
}
