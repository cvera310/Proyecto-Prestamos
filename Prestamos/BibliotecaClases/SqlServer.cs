using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class SqlServer
    {
        public static string CADENA_CONEXION = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;

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
