using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class SqlServer
    {
        public const string CADENA_CONEXION = "Data Source = MARTINGIMENEZ\\SQLEXPRESS; Initial Catalog = prestamo; User Id=sa; Password = 123456; MultipleActiveResultSets=true;";
    

        public static bool VerifyConnection()
        {
                SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION);
               try
                {
                    con.Open();
                    con.Close();
                    return true;
                }
                catch
                {
                    return false;
                }

        }

    }
}
