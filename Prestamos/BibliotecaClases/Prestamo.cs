using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
  
    public class Prestamo 
    {
        public int NumeroPrestamo {get; set;}
        public int MontoSolicitado { get; set; }
        public double MontoTotal {get; set;}
        public int CantidadCuota {get; set;}
        public int InteresGenerado {get; set;}
        public int InteresBase { get; set; }
        //public Cliente cliente {get; set;}
        public String cliente { get; set; }
        public double Saldo { get; set; }
        public Moneda moneda { get; set; }
        public TipoPrestamo tipoPrestamo { get; set; }
        public DateTime Fecha { get; set; }

        public static List <Prestamo> ListaPrestamo = new List<Prestamo>();
        public List<PrestamoDetalle> ListaPrestamoDetalle = new List<PrestamoDetalle>();

        public static void Agregar (Prestamo p)
        {
            //ListaPrestamo.Add(p);  
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string GuardarCabecera = "INSERT INTO prestamo (pre_fecha,pre_cliente,pre_tipoprestamo,pre_montosolicitado,pre_moneda,pre_cantcuota,pre_interes,pre_montototal,usuario)" +
                                        " output INSERTED.pre_numero " +
                                        "VALUES (@Fecha ,@Cliente, @TipoPrestamo, @MontoSolicitado, @Moneda, @Cuota, @Interes, @MontoTotal, @usuario)";
                SqlCommand cmd = new SqlCommand(GuardarCabecera, con);
                
                SqlParameter cab2 = new SqlParameter("@Fecha", p.Fecha);
                SqlParameter cab3 = new SqlParameter("@Cliente", p.cliente);
                SqlParameter cab4 = new SqlParameter("@TipoPrestamo", p.tipoPrestamo.Codigo);
                SqlParameter cab5 = new SqlParameter("@MontoSolicitado", p.MontoSolicitado);
                SqlParameter cab6 = new SqlParameter("@Moneda", p.moneda.Codigo);
                SqlParameter cab7 = new SqlParameter("@Cuota", p.CantidadCuota);
                SqlParameter cab8 = new SqlParameter("@Interes", p.InteresBase);
                SqlParameter cab9 = new SqlParameter("@MontoTotal", p.MontoTotal);
                SqlParameter cab10 = new SqlParameter("@Usuario", LoginUsuario.UsuarioConectado());
                
                cab2.SqlDbType = SqlDbType.Date;
                cab3.SqlDbType = SqlDbType.VarChar;
                cab4.SqlDbType = SqlDbType.VarChar;
                cab5.SqlDbType = SqlDbType.Int;
                cab6.SqlDbType = SqlDbType.VarChar;
                cab7.SqlDbType = SqlDbType.Int;
                cab8.SqlDbType = SqlDbType.Int;
                cab9.SqlDbType = SqlDbType.Int;
                cab10.SqlDbType = SqlDbType.VarChar;
                
                cmd.Parameters.Add(cab2);
                cmd.Parameters.Add(cab3);
                cmd.Parameters.Add(cab4);
                cmd.Parameters.Add(cab5);
                cmd.Parameters.Add(cab6);
                cmd.Parameters.Add(cab7);
                cmd.Parameters.Add(cab8);
                cmd.Parameters.Add(cab9);
                cmd.Parameters.Add(cab10);

                int prestamo_id = (int)cmd.ExecuteScalar();



                foreach (PrestamoDetalle pd in p.ListaPrestamoDetalle)
                {
                    string GuardarDetalle = "INSERT INTO prestamo_detalle (predet_nrocabecera,predet_nrocuota,predet_monto,predet_saldo,predet_vencimiento,predet_estado)"
                                             + "VALUES (@NroCabecera, @NroCuota, @Monto, @Saldo, @Vencimiento, @Estado)";
                    SqlCommand QUERY_GuardarDetalle = new SqlCommand(GuardarDetalle, con);
                    SqlParameter det1 = new SqlParameter("@NroCabecera", prestamo_id);
                    SqlParameter det2 = new SqlParameter("@NroCuota", pd.NroCuota);
                    SqlParameter det3 = new SqlParameter("@Monto", pd.MontoDetalle);
                    SqlParameter det4 = new SqlParameter("@Saldo", pd.SaldoDetalle);
                    SqlParameter det5 = new SqlParameter("@Vencimiento", pd.Vencimiento);
                    SqlParameter det6 = new SqlParameter("@Estado", pd.estado);
                    det1.SqlDbType = SqlDbType.Int;
                    det2.SqlDbType = SqlDbType.Int;
                    det3.SqlDbType = SqlDbType.Int;
                    det4.SqlDbType = SqlDbType.Int;
                    det5.SqlDbType = SqlDbType.Date;
                    det6.SqlDbType = SqlDbType.VarChar;
                    QUERY_GuardarDetalle.Parameters.Add(det1);
                    QUERY_GuardarDetalle.Parameters.Add(det2);
                    QUERY_GuardarDetalle.Parameters.Add(det3);
                    QUERY_GuardarDetalle.Parameters.Add(det4);
                    QUERY_GuardarDetalle.Parameters.Add(det5);
                    QUERY_GuardarDetalle.Parameters.Add(det6);
                    QUERY_GuardarDetalle.ExecuteNonQuery();

                }
            }
             p.ListaPrestamoDetalle.Clear();
        }

        public static void Eliminar (Prestamo p)
        {
            ListaPrestamo.Add(p);
        }

        public static List<Prestamo> ObtenerPrestamo()
        {
            return ListaPrestamo;
        }

    }
}
