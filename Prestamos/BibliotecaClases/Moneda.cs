using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Moneda
    {
        public String Codigo { get; set; }
        public String Descripcion { get; set; }
        public String PaisProcedencia { get; set; }

        //public List<MonedaDetalle> detalle_moneda = new List<MonedaDetalle>();
       // public String CantidadDisponible { get; set; }

        public static List<Moneda> ListaMoneda = new List<Moneda>();

        public static void Agregar (Moneda m)
        {
            //ListaMoneda.Add(m);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"insert into moneda (mon_codigo, mon_descripcion, mon_pais) VALUES (@Codigo, @Descripcion, @Pais)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter m1 = new SqlParameter("@Codigo", m.Codigo);
                SqlParameter m2 = new SqlParameter("@Descripcion", m.Descripcion);
                SqlParameter m3 = new SqlParameter("@Pais", m.PaisProcedencia);

                m1.SqlDbType = SqlDbType.VarChar;
                m2.SqlDbType = SqlDbType.VarChar;
                m3.SqlDbType = SqlDbType.VarChar;

                cmd.Parameters.Add(m1);
                cmd.Parameters.Add(m2);
                cmd.Parameters.Add(m3);
                cmd.ExecuteNonQuery();


            }
        }
    
      
        public static void Eliminar (Moneda m)
        {
            //ListaMoneda.Remove(m);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from moneda where mon_codigo = @codigo";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter m1 = new SqlParameter("@codigo", m.Codigo);
                m1.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(m1);

                cmd.ExecuteNonQuery();
            }
        }
        public static void EditarMoneda(int index, Moneda m)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE moneda SET mon_descripcion = @descripcion, mon_pais= @pais where mon_codigo = @Id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter m1 = new SqlParameter("@descripcion", m.Descripcion);
                SqlParameter m2 = new SqlParameter("@pais", m.PaisProcedencia);
                SqlParameter m3 = new SqlParameter("@Id", m.Codigo);
                m1.SqlDbType = SqlDbType.VarChar;
                m2.SqlDbType = SqlDbType.VarChar;
               
                cmd.Parameters.Add(m1);
                cmd.Parameters.Add(m2);
                cmd.Parameters.Add(m3);
                cmd.ExecuteNonQuery();
            }
        }
        public static List<Moneda> ListarMoneda()
        {

            Moneda moneda;
            ListaMoneda.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "SELECT mon_codigo as Codigo, mon_descripcion as Descripcion, mon_pais as Pais " +
                                    "FROM moneda";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    moneda = new Moneda();
                    moneda.Codigo = elLectorDeDatos.GetString(0);
                    moneda.Descripcion = elLectorDeDatos.GetString(1);
                    moneda.PaisProcedencia = elLectorDeDatos.GetString(2);

                    ListaMoneda.Add(moneda);
                }
            }
            return ListaMoneda;
        }

        public override string ToString()
        {
            return Codigo;
        }
         
        public static Moneda ObtenerMoneda(string codigo)
        {
            Moneda moneda = null;
            if(ListaMoneda.Count==0) Moneda.ListarMoneda();

            foreach (Moneda m in ListaMoneda)
            {
                if (m.Codigo == codigo)
                {
                    moneda = m;
                    break;
                }
            }
            return moneda;
        }

    }
}
