using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Cobranza 
    {

        public int Codigo { get; set; }
        public int MontoTotal { get; set; }
        public int TotalMora { get; set; }
        public int TotalDcto { get; set; }
        public List<CobranzaDetalle> detalle_cobranza = new List<CobranzaDetalle>();
        public static List<DetalleFpagoCobranza> detalle_fpagocobranza = new List<DetalleFpagoCobranza>();

        public static int Agregar(Cobranza c)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string SQL_InsertarCobranza = "INSERT INTO cobranza (cob_montototal, cob_totalmora, cob_totaldcto)"+
                                              " output INSERTED.cob_nro " +
                                              " VALUES (@MontoTotal, @TotalMora, @TotalDcto)";
                SqlCommand cmd = new SqlCommand(SQL_InsertarCobranza, con);

                SqlParameter c1 = new SqlParameter("@MontoTotal", c.MontoTotal);
                SqlParameter c2 = new SqlParameter("@TotalMora", c.TotalMora);
                SqlParameter c3 = new SqlParameter("@TotalDcto", c.TotalDcto);
                c1.SqlDbType = SqlDbType.Int;
                c2.SqlDbType = SqlDbType.Int;
                c3.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(c1);
                cmd.Parameters.Add(c2);
                cmd.Parameters.Add(c3);

                int cobranza_id = (int)cmd.ExecuteScalar();

                foreach (CobranzaDetalle cd in c.detalle_cobranza)
                {
                    string textoCmd2 = @"insert into cobranza_detalle (cobcab_nro, cobdet_preid, cobdet_mora, cobdet_dcto) VALUES (@idcabecera, @idprestamo, @mora, @dcto)";
                    SqlCommand cmd2 = new SqlCommand(textoCmd2, con);

                    SqlParameter c4 = new SqlParameter("@idcabecera", cobranza_id);
                    SqlParameter c5 = new SqlParameter("@idprestamo", cd.prestamoId);
                    SqlParameter c6 = new SqlParameter("@mora", cd.mora);
                    SqlParameter c7 = new SqlParameter("@dcto", cd.dcto);
                    
                    c4.SqlDbType = SqlDbType.Int;
                    c5.SqlDbType = SqlDbType.Int;
                    c6.SqlDbType = SqlDbType.Int;
                    c7.SqlDbType = SqlDbType.Int;
                    
                    cmd2.Parameters.Add(c4);
                    cmd2.Parameters.Add(c5);
                    cmd2.Parameters.Add(c6);
                    cmd2.Parameters.Add(c7);

                    cmd2.ExecuteNonQuery();

                    string updateEstado = @"UPDATE prestamo_detalle SET predet_saldo=0, predet_estado=@Estado WHERE  predet_id=@Id";
                    SqlCommand update = new SqlCommand(updateEstado, con);

                    //SqlParameter up1 = new SqlParameter("@Saldo", 0);
                    SqlParameter up2 = new SqlParameter("@Estado", EstadoPrestamo.Pagado);
                    SqlParameter up3 = new SqlParameter("@Id", cd.prestamoId);

                    //up1.SqlDbType = SqlDbType.Int;
                    up2.SqlDbType = SqlDbType.VarChar;
                    up3.SqlDbType = SqlDbType.Int;

                    //update.Parameters.Add(up1);
                    update.Parameters.Add(up2);
                    update.Parameters.Add(up3);


                    update.ExecuteNonQuery();





                }

                foreach (DetalleFpagoCobranza dfp in detalle_fpagocobranza)
                {
                    string textoCmd3 = @"INSERT INTO cobranza_cheque (cobcheque_nro, cob_nro, cobcheque_fecha,cobcheque_monto, cobcheque_tipo) "+
                                       " VALUES (@NroCheque,@CobranzaId,@FechaCheque,@ChequeMonto, @TipoCheque)";
                    SqlCommand cmd3 = new SqlCommand(textoCmd3, con);
                    
                    SqlParameter c8 = new SqlParameter("@NroCheque", dfp.numeroCheque.ToString().PadLeft(8, '0'));
                    SqlParameter c9 = new SqlParameter("@CobranzaId", cobranza_id);
                    SqlParameter c10 = new SqlParameter("@FechaCheque", dfp.fechaCheque);
                    SqlParameter c11 = new SqlParameter("@ChequeMonto", dfp.montoCheque);
                    SqlParameter c12 = new SqlParameter("@TipoCheque", dfp.cheque.Codigo);
                  
                    c8.SqlDbType = SqlDbType.VarChar;
                    c9.SqlDbType = SqlDbType.Int;
                    c10.SqlDbType = SqlDbType.DateTime;
                    c11.SqlDbType = SqlDbType.Int;
                    c12.SqlDbType = SqlDbType.VarChar;
                    
                    cmd3.Parameters.Add(c8);
                    cmd3.Parameters.Add(c9);
                    cmd3.Parameters.Add(c10);
                    cmd3.Parameters.Add(c11);
                    cmd3.Parameters.Add(c12);
                    try
                    {
                        cmd3.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ocurrio error al insertar "+ex.Message);
                    }
                    
                }

                return cobranza_id;
            }
            
        }

       public static DataTable ObtenerPrestamoCliente(string CedulaCliente)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "SELECT pre_numero as NumeroPrestamo, "+
                                        "tpre_descripcion as TipoPrestamo,"+
                                        "predet_nrocuota as NumeroCuota,"+
                                        "predet_monto as Monto,"+
                                        "predet_vencimiento as Vencimiento, "+
                                        "CASE "+
                                            "WHEN predet_vencimiento < CONVERT(DATE, GETDATE()) AND DATEDIFF(month, predet_vencimiento, CONVERT(DATE, GETDATE())) <= 1   THEN CONVERT(int, predet_monto * 0.1) "+
	                                        "WHEN predet_vencimiento<CONVERT(DATE, GETDATE()) AND DATEDIFF(month, predet_vencimiento, CONVERT(DATE, GETDATE())) > 1   THEN CONVERT(int, predet_monto * 0.2) "+
	                                        "else 0 "+
                                        "END "+
                                        "AS Mora, "+
                                        "CASE "+
                                            "WHEN predet_vencimiento > CONVERT(DATE, GETDATE()) AND DATEDIFF(month, CONVERT(DATE, GETDATE()),predet_vencimiento) >= 1   THEN CONVERT(int, predet_monto*0.04) "+
	                                        "else 0 "+
                                        "END "+
                                        "AS Dcto, "+
                                        "predet_id "+
                                    "FROM Cliente " +
                                        "INNER JOIN prestamo ON prestamo.pre_cliente = Cliente.Documento "+
                                        "INNER JOIN prestamo_detalle ON prestamo_detalle.predet_nrocabecera = prestamo.pre_numero "+
                                        "INNER JOIN tipo_prestamo ON prestamo.pre_tipoprestamo = tipo_prestamo.tpre_codigo "+
                                    "WHERE Cliente.Documento = @Cedula "+
                                    "AND predet_estado='No_pagado'";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter c = new SqlParameter("@Cedula", CedulaCliente);
                c.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(c);

                DataTable tabla = new DataTable();
                tabla.Load(cmd.ExecuteReader());
                return tabla;

            }
        }

        public static int ObtenerNroRecibo()
        {
            int NroRecibo = 0;
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "SELECT ISNULL(MAX(cob_nro),0)+1 FROM cobranza";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                    NroRecibo = dr.GetInt32(0);

                return NroRecibo;
            }
        }
    }
}
