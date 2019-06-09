using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    //No binarie en leguaje inclusive
    public enum Sexo
    {
        Masculino,
        Femenimo,
        No_Binarie
    }

    public enum TipoDocumento
    {
        CI,
        DNI,
        RUC
    }

    public class Cliente
    {
        public int NumeroCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public TipoDocumento TipoDeDocumento { get; set; }
        public string Documento { get; set; }
        //public Sexo Sexo { get; set; }
        public String RazonSocial { get; set; }
        public DateTime Nacimiento { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }
        //public String Foto { get; set; }

        public String LugarTrabajo { get; set; }
        public int AntiguedadLaboral { get; set; }
        //public String FajaInformconf { get; set; }
        //public Boolean Informconf { get; set; }
        //public TipoDocumento tipo_documento { get; set; }
        public Sexo sexo { get; set; }


        public static List<Cliente> ListaCliente = new List<Cliente>();

        public static void Agregar(Cliente c)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"INSERT INTO Cliente(Nombre, Apellido, TipoDocumento, Documento, Sexo, RazonSocial, Nacimiento, Telefono, Direccion,
                   LugarTrabajo, AntiguedadLaboral) VALUES (@Nombre, @Apellido, @TipoDeDocumento, @Documento, @Sexo, @RazonSocial, @Nacimiento, @Telefono, @Direccion,
                   @LugarTrabajo, @AntiguedadLaboral)";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = c.ObtenerParametros(cmd);

                cmd.ExecuteNonQuery();


            }
            //ListaCliente.Add(c);
        }

        public static void Eliminar(Cliente c)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from Cliente where NumeroCliente = @NumeroCliente";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter c1 = new SqlParameter("@NumeroCliente", c.NumeroCliente);
                c1.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(c1);

                cmd.ExecuteNonQuery();


            }
        }

        public static void Editar(int index, Cliente c)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE Cliente SET Nombre = @Nombre, Apellido= @Apellido, TipoDocumento =@TipoDeDocumento, Documento = @Documento, Sexo = @Sexo, RazonSocial =@RazonSocial, Nacimiento =@Nacimiento, Telefono = @Telefono, 
                Direccion = @Direccion, LugarTrabajo = @LugarTrabajo, AntiguedadLaboral = @AntiguedadLaboral
                where NumeroCliente = @NumeroCliente";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = c.ObtenerParametros(cmd);

                cmd.ExecuteNonQuery();





            }


        }

        public static List<Cliente> ListarCliente()
        {
            Cliente cliente;
            ListaCliente.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "SELECT * from Cliente";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    cliente = new Cliente();
                    cliente.NumeroCliente = elLectorDeDatos.GetInt32(0);
                    cliente.Nombre = elLectorDeDatos.GetString(1);
                    cliente.Apellido = elLectorDeDatos.GetString(2);
                    cliente.TipoDeDocumento = (TipoDocumento)elLectorDeDatos.GetInt32(3);
                    cliente.Documento = elLectorDeDatos.GetString(4);
                    cliente.sexo = (Sexo)elLectorDeDatos.GetInt32(5);
                    cliente.RazonSocial = elLectorDeDatos.GetString(6);
                    cliente.Nacimiento = elLectorDeDatos.GetDateTime(7);
                    cliente.Telefono = elLectorDeDatos.GetString(8);
                    cliente.Direccion = elLectorDeDatos.GetString(9);
                    cliente.LugarTrabajo = elLectorDeDatos.GetString(10);
                    cliente.AntiguedadLaboral = elLectorDeDatos.GetInt32(11);

                    ListaCliente.Add(cliente);

                }

            }


            return ListaCliente;
        }

        public override string ToString()
        {
            return  Nombre;
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {
            SqlParameter p1 = new SqlParameter("@Nombre", this.Nombre);
            SqlParameter p2 = new SqlParameter("@Apellido", this.Apellido);
            SqlParameter p3 = new SqlParameter("@TipoDeDocumento", this.TipoDeDocumento);
            SqlParameter p4 = new SqlParameter("@Documento", this.Documento);
            SqlParameter p5 = new SqlParameter("@Sexo", this.sexo);
            SqlParameter p6 = new SqlParameter("@RazonSocial", this.RazonSocial);
            SqlParameter p7 = new SqlParameter("@Nacimiento", this.Nacimiento);
            SqlParameter p8 = new SqlParameter("@Telefono", this.Telefono);
            SqlParameter p9 = new SqlParameter("@Direccion", this.Direccion);
            SqlParameter p10 = new SqlParameter("@LugarTrabajo", this.LugarTrabajo);
            SqlParameter p11 = new SqlParameter("@AntiguedadLaboral", this.AntiguedadLaboral);
            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.Int;
            p4.SqlDbType = SqlDbType.VarChar;
            p5.SqlDbType = SqlDbType.Int;
            p6.SqlDbType = SqlDbType.VarChar;
            p7.SqlDbType = SqlDbType.DateTime;
            p8.SqlDbType = SqlDbType.VarChar;
            p9.SqlDbType = SqlDbType.VarChar;
            p10.SqlDbType = SqlDbType.VarChar;
            p11.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);
            cmd.Parameters.Add(p9);
            cmd.Parameters.Add(p10);
            cmd.Parameters.Add(p11);

            if (id == true) cmd = ObtenerParametroId(cmd);

            return cmd;


        }

        private SqlCommand ObtenerParametroId(SqlCommand cmd)
        {
            SqlParameter p12 = new SqlParameter("@NumeroCliente", this.NumeroCliente);
            p12.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(12);
            return cmd;
        }


    }
}
