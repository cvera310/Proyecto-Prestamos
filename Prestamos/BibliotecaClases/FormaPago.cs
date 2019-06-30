using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class FormaPago
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public static List<FormaPago> ListaFormaPago = new List<FormaPago>();

        public static void Agregar(FormaPago fp)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string SQL_InsertarFormaPago = @"insert into forma_pago (fpa_codigo, fpa_descripcion) VALUES (@Codigo, @Descripcion)";
                SqlCommand cmd = new SqlCommand(SQL_InsertarFormaPago, con);
                SqlParameter fp1 = new SqlParameter("@Codigo", fp.Codigo);
                SqlParameter fp2 = new SqlParameter("@Descripcion", fp.Descripcion);

                fp1.SqlDbType = SqlDbType.VarChar;
                fp2.SqlDbType = SqlDbType.VarChar;

                cmd.Parameters.Add(fp1);
                cmd.Parameters.Add(fp2);

                cmd.ExecuteNonQuery();
            }
        }

        public static void Editar (FormaPago fp)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string SQL_ModificarFormaPago = @"UPDATE forma_pago SET fpa_descripcion = @descripcion WHERE fpa_codigo = @Id";
                SqlCommand cmd = new SqlCommand(SQL_ModificarFormaPago, con);
                SqlParameter fp1 = new SqlParameter("@descripcion", fp.Descripcion);
                SqlParameter fp2 = new SqlParameter("@Id", fp.Codigo);
                fp1.SqlDbType = SqlDbType.VarChar;
                fp2.SqlDbType = SqlDbType.VarChar;

                cmd.Parameters.Add(fp1);
                cmd.Parameters.Add(fp2);
               
                cmd.ExecuteNonQuery();
            }
        }

        public static void Eliminar (FormaPago fp)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string SQL_EliminarFormaPago = @"DELETE FROM forma_pago WHERE fpa_codigo = @codigo";

                SqlCommand cmd = new SqlCommand(SQL_EliminarFormaPago, con);
                SqlParameter fp1 = new SqlParameter("@codigo", fp.Codigo);
                fp1.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(fp1);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<FormaPago> ListarFormaPago()
        {
            FormaPago formaPago;
            ListaFormaPago.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string SQL_ListarFormaPago = "SELECT * " +
                                    "FROM forma_pago";

                SqlCommand cmd = new SqlCommand(SQL_ListarFormaPago, con);
                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    formaPago = new FormaPago();
                    formaPago.Codigo = elLectorDeDatos.GetString(0);
                    formaPago.Descripcion = elLectorDeDatos.GetString(1);

                    ListaFormaPago.Add(formaPago);
                }
            }
            return ListaFormaPago;
        }
        public static List<FormaPago> ObtenerCheques()
        {
            FormaPago formaPago;
            List<FormaPago> listaCheques = new List<FormaPago>();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string SQL_ListarFormaPago = "SELECT * FROM forma_pago WHERE fpa_codigo LIKE '%ch%'";
                SqlCommand cmd = new SqlCommand(SQL_ListarFormaPago, con);
                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    formaPago = new FormaPago();
                    formaPago.Codigo = elLectorDeDatos.GetString(0);
                    formaPago.Descripcion = elLectorDeDatos.GetString(1);

                    listaCheques.Add(formaPago);
                }
            }
            return listaCheques;
        }

        public static FormaPago ObtenerFormaPago(string codigo)
        {
            FormaPago formaPago = null;
            if (ListaFormaPago.Count == 0) FormaPago.ListarFormaPago();

            foreach (FormaPago fp in ListaFormaPago)
            {
                if (fp.Codigo == codigo)
                {
                    formaPago = fp;
                    break;
                }
            }
            return formaPago;
        }
        public override string ToString()
        {
            return Descripcion;
        }

    }
}
