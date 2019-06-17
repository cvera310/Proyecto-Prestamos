using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public enum Cargo {Atc, Caja, Tesoreria}
    public class Personal 
    {
        public int NumeroEmpleado {get; set;}
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public Cargo Cargo { get; set; }
        public DateTime FechaNac { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public TipoDocumento TipoDeDocumento { get; set; }
        public Sexo sexo { get; set; }
        //public string Foto { get; set; }



        public static List<Personal> ListaPersonal = new List<Personal>();

        public static void Agregar(Personal p)
        {
            //ListaPersonal.Add(p);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"INSERT INTO personal(Nombre, Apellido, Documento, Cargo, FechaNac, Telefono, Direccion,
                   TipoDeDocumento, sexo) VALUES (@Nombre, @Apellido, @Documento, @Cargo, @FechaNac, @Telefono, @Direccion, @TipoDeDocumento, @sexo)";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = p.ObtenerParametros(cmd);

                cmd.ExecuteNonQuery();


            }
        }
        public static void Eliminar(Personal p)
            {
                using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
                {
                con.Open();
                string textoCmd = @"delete from Personal where NumeroEmpleado = @NumeroEmpleado";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter c1 = new SqlParameter("@NumeroEmpleado", p.NumeroEmpleado);
                c1.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(c1);

                cmd.ExecuteNonQuery();


                }

            // ListaPersonal.Remove(p);
        }

        public static void Editar(Personal p)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                /*con.Open();
                string textoCmd = @"UPDATE Personal SET Nombre = @Nombre, Apellido = @Apellido, Documento = @Documento, Cargo = @Cargo, FechaNac = @FechaNac, 
                Telefono = @Telefono, Direccion = @Direccion, TipoDeDocumento = @TipoDeDocumento, sexo = @sexo
                where NumeroEmpleado = @NumeroEmpleado";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = p.ObtenerParametros(cmd);

                cmd.ExecuteNonQuery();*/

                con.Open();
                string textoCmd = @"UPDATE Personal SET Nombre = @Nombre, Apellido = @Apellido, Documento = @Documento, Cargo = @Cargo, FechaNac = @FechaNac, 
                Telefono = @Telefono, Direccion = @Direccion, TipoDeDocumento = @TipoDeDocumento, sexo = @sexo
                where NumeroEmpleado = @NumeroEmpleado";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter c1 = new SqlParameter("@NumeroEmpleado", p.NumeroEmpleado);
                cmd = p.ObtenerParametros(cmd);
                c1.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(c1);

                cmd.ExecuteNonQuery();




            }


        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {
            SqlParameter p1 = new SqlParameter("@Nombre", this.Nombre);
            SqlParameter p2 = new SqlParameter("@Apellido", this.Apellido);
            SqlParameter p3 = new SqlParameter("@Documento", this.Documento);
            SqlParameter p4 = new SqlParameter("@Cargo", this.Cargo);
            SqlParameter p5 = new SqlParameter("@FechaNac", this.FechaNac);
            SqlParameter p6 = new SqlParameter("@Telefono", this.Telefono);
            SqlParameter p7 = new SqlParameter("@Direccion", this.Direccion);
            SqlParameter p8 = new SqlParameter("@TipoDeDocumento", this.TipoDeDocumento);
            SqlParameter p9 = new SqlParameter("@sexo", this.sexo);
            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.VarChar;
            p4.SqlDbType = SqlDbType.Int;
            p5.SqlDbType = SqlDbType.DateTime;
            p6.SqlDbType = SqlDbType.VarChar;
            p7.SqlDbType = SqlDbType.VarChar;
            p8.SqlDbType = SqlDbType.Int;
            p9.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);
            cmd.Parameters.Add(p9);

            if (id == true) cmd = ObtenerParametroId(cmd);

            return cmd;


        }

        private SqlCommand ObtenerParametroId(SqlCommand cmd)
        {
            SqlParameter p10 = new SqlParameter("@NumeroEmpleado", this.NumeroEmpleado);
            p10.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(10);
            return cmd;
        }

        public static List<Personal> ListarPersonal()
        {
            Personal personal;
            ListaPersonal.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "SELECT * from personal";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    personal = new Personal();
                    personal.NumeroEmpleado = elLectorDeDatos.GetInt32(0);
                    personal.Nombre = elLectorDeDatos.GetString(1);
                    personal.Apellido = elLectorDeDatos.GetString(2);
                    personal.Documento = elLectorDeDatos.GetString(3);
                    personal.Cargo = (Cargo)elLectorDeDatos.GetInt32(4);
                    personal.FechaNac = elLectorDeDatos.GetDateTime(5);
                    personal.Telefono = elLectorDeDatos.GetString(6);
                    personal.Direccion = elLectorDeDatos.GetString(7);
                    personal.TipoDeDocumento = (TipoDocumento)elLectorDeDatos.GetInt32(8);
                    personal.sexo = (Sexo)elLectorDeDatos.GetInt32(9);
                    ListaPersonal.Add(personal);

                }

            }

            return ListaPersonal;
        }


     

        public override string ToString()
        {
            return this.Nombre;
        }


    }
}
