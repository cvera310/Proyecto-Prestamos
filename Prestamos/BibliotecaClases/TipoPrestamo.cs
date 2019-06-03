using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class TipoPrestamo
    {
        public String Codigo { get; set; }
        public String Descripcion {get; set;}
        public int InteresBase {get; set;}

        public static List<TipoPrestamo> ListaTipoPrestamo = new List<TipoPrestamo>();

        public static void Agregar(TipoPrestamo tp)
        {
            //ListaTipoPrestamo.Add(tp);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"INSERT INTO tipo_prestamo (tpre_codigo, tpre_descripcion, tpre_interes) VALUES (@Codigo, @Descripcion, @Interes) ";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlParameter tpre1 = new SqlParameter("@Codigo", tp.Codigo);
                SqlParameter tpre2 = new SqlParameter("@Descripcion", tp.Descripcion);
                SqlParameter tpre3 = new SqlParameter("@Interes", tp.InteresBase);
                tpre1.SqlDbType = SqlDbType.VarChar;
                tpre2.SqlDbType = SqlDbType.VarChar;
                tpre3.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(tpre1);
                cmd.Parameters.Add(tpre2);
                cmd.Parameters.Add(tpre3);
                               
                cmd.ExecuteNonQuery();
            }
        }
        public static void Eliminar(TipoPrestamo tp)
        {
            // ListaTipoPrestamo.Remove(tp);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"DELETE FROM tipo_prestamo WHERE tpre_codigo=@Codigo";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter tpre1 = new SqlParameter("@Codigo", tp.Codigo);
                tpre1.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(tpre1);
                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarTipoPrestamo(int codigo, TipoPrestamo tp)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE tipo_prestamo SET tpre_descripcion=@Descripcion, tpre_interes=@Interes WHERE tpre_codigo=@Codigo";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter tpre1 = new SqlParameter("@Descripcion", tp.Descripcion);
                SqlParameter tpre2 = new SqlParameter("@Interes", tp.InteresBase);
                SqlParameter tpre3 = new SqlParameter("@Codigo", tp.Codigo);
                tpre1.SqlDbType = SqlDbType.VarChar;
                tpre2.SqlDbType = SqlDbType.Int;
                tpre3.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(tpre1);
                cmd.Parameters.Add(tpre2);
                cmd.Parameters.Add(tpre3);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<TipoPrestamo> ObtenerTipoPrestamos()
        {
            //return ListaTipoPrestamo;
            TipoPrestamo tipoPrestamo;
            ListaTipoPrestamo.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "SELECT * FROM tipo_prestamo";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    tipoPrestamo = new TipoPrestamo();
                    tipoPrestamo.Codigo = elLectorDeDatos.GetString(0);
                    tipoPrestamo.Descripcion = elLectorDeDatos.GetString(1);
                    tipoPrestamo.InteresBase = elLectorDeDatos.GetInt32(2);
                    ListaTipoPrestamo.Add(tipoPrestamo);
                }
            }
            return ListaTipoPrestamo;
        }

        public static TipoPrestamo ObtenerTipoPrestamo(string codigo)
        {
            TipoPrestamo tipoPrestamo = null;
            if (ListaTipoPrestamo.Count == 0) TipoPrestamo.ObtenerTipoPrestamos();

            foreach (TipoPrestamo tp in ListaTipoPrestamo)
            {
                if (tp.Codigo == codigo)
                {
                    tipoPrestamo = tp;
                    break;
                }
            }
            return tipoPrestamo;
        }

        public override string ToString()
        {
            return Descripcion;
        }

        
    }
}
