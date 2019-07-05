using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class EvaluacionCredito
    {
        public enum TipoPago
        {
            Mensual,
            Quincenal,
            Jornal
        }

        

        



        
        

       // public int Alimentacion { get; set; }
        //public int Alquiler { get; set; }
        //public int ServiciosBasicos { get; set; }
        //public int Transporte { get; set; }
        //public int Otros { get; set; }
        public int id { get; set; }
        public double TotalEgresos { get; set; }
        public int Salario { get; set; }
        public double TotalIngresos { get; set; }
        public TipoPago tipo_pago { get; set; }
        public string cliente { get; set; }


        public string informconf { get; set; }
        public string aprobado { get; set; }
        // public int IngresoExtra { get; set; }

        public static List<EvaluacionCredito> listaEvaluacion = new List<EvaluacionCredito>();
        //public static List<EvaluacionCredito> Pendiente = new List<EvaluacionCredito>();

        public static List<DetalleEgresos> detalle_egresos = new List<DetalleEgresos>();
        public static List<DetalleIngresos> detalle_ingresos = new List<DetalleIngresos>();


        public static void Agregar(EvaluacionCredito ec)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into Solicitud_Credito (NumeroCliente, TotalEgreso, TotalIngreso, Informconf) VALUES (@NumeroCliente, @TotalEgreso, @TotalIngreso, @Informconf)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = ec.ObtenerParametros(cmd, false);

                cmd.ExecuteNonQuery();


            }
        }


        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {
            SqlParameter p1 = new SqlParameter("@NumeroCliente", this.cliente);
            SqlParameter p2 = new SqlParameter("@TotalEgreso", this.TotalEgresos);
            SqlParameter p3 = new SqlParameter("@TotalIngreso", this.TotalIngresos);
            // SqlParameter p4 = new SqlParameter("@Informconf", ConsultaInformconf());
            SqlParameter p4 = new SqlParameter("@Informconf", this.informconf);
            //SqlParameter p5 = new SqlParameter("@aprobado", this.aprobado);
            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.Int;
            p3.SqlDbType = SqlDbType.Int;
            p4.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            //cmd.Parameters.Add(p5);
            if (id == true)
            {
                cmd = ObtenerParametroId(cmd);
            }


            return cmd;

        }


        private SqlCommand ObtenerParametroId(SqlCommand cmd)
        {
            SqlParameter p5 = new SqlParameter("@id", this.id);
            p5.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p5);

            return cmd;
        }

        //Consulta en tabla de informconf si el cliente tiene o no 

        public static string ConsultaInformconf(string cedula)
        {
            string informconf = "";
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                   string textoCmd = @"SELECT
                        CASE
                            WHEN Documento != null THEN 'S'
                            ELSE 'N'
                            END AS Informconf
                            FROM Informconf
                            WHERE Documento = @Cedula";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter p10 = new SqlParameter("@Cedula", cedula);
                p10.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p10);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    informconf = dr.GetString(0);

                return informconf;

            }

        }


        public static void Eliminar(EvaluacionCredito ec)
        {
            listaEvaluacion.Remove(ec);
        }

        public static List<EvaluacionCredito> Obtener()
        {
            return listaEvaluacion;
        }

        public static DataTable ObtenerPendientes()
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "select s.id, s.NumeroCliente,c.Nombre, c.Apellido, s.TotalIngreso, s.TotalEgreso, s.Informconf from Solicitud_Credito s join cliente c on c.Documento = s.NumeroCliente and aprobado IS NOT NULL";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                DataTable tabla = new DataTable();
                tabla.Load(cmd.ExecuteReader());
                return tabla;

            }

        }


        public static void ConfirmarPendientes(List<int> listaPend)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                foreach (int id in listaPend)
                {
                    string textoCmd = @"UPDATE Solicitud_Credito SET aprobado = 'S' where id = @id";
                    SqlCommand cmd = new SqlCommand(textoCmd, con);
                    SqlParameter p1 = new SqlParameter("@id", id);
                    p1.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(p1);
                    cmd.ExecuteNonQuery();
                }

            }
        }




    }
}
