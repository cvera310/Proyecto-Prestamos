using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public enum EstadoPrestamo { Pagado, No_pagado }
    public class PrestamoDetalle : Prestamo
    {
        public int NroCuota { get; set; }
        public double MontoDetalle { get; set; }
        public double SaldoDetalle { get; set; }
        public DateTime Vencimiento { get; set; }
        public EstadoPrestamo estado { get; set; }

        public static List<PrestamoDetalle> ListaPrestamoDetalle = new List<PrestamoDetalle>();
        
        public static void Agregar(PrestamoDetalle pd)
        {
            ListaPrestamoDetalle.Add(pd);

        }

        public static void Eliminar (PrestamoDetalle pd)
        {
            ListaPrestamoDetalle.Remove(pd);
        }

        public static List<PrestamoDetalle> ObtenerPrestamoDetalle()
        {
            return ListaPrestamoDetalle;
        }

        public static void GuardarBd()
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                foreach (PrestamoDetalle pd in ListaPrestamoDetalle)
                {
                    string GuardarDetalle = "INSERT INTO prestamo_detalle (predet_nrocabecera,predet_nrocuota,predet_monto,predet_saldo,predet_vencimiento,predet_estado)"
                                             + "VALUES (@NroCabecera, @NroCuota, @Monto, @Saldo, @Vencimiento, @Estado)";
                    SqlCommand cmd = new SqlCommand(GuardarDetalle, con);
                    SqlParameter det1 = new SqlParameter("@NroCabecera", pd.NumeroPrestamo);
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
                    cmd.Parameters.Add(det1);
                    cmd.Parameters.Add(det2);
                    cmd.Parameters.Add(det3);
                    cmd.Parameters.Add(det4);
                    cmd.Parameters.Add(det5);
                    cmd.Parameters.Add(det6);
                    cmd.ExecuteNonQuery();
                    
                }
            }
            ListaPrestamoDetalle.Clear();

        }


    }
}
