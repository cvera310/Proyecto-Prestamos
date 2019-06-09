using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Usuario
    {
        public string Codigo { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public DateTime UltimoAcceso { get; set; }
        public static List<Usuario> ListaUsuario = new List<Usuario>();

        public static void Agregar(Usuario u)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "INSERT INTO usuario (usu_codigo, usu_clave, usu_nombrecompleto) VALUES (@Codigo, @Clave, @Nombre)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter u1 = new SqlParameter("@Codigo", u.Codigo);
                SqlParameter u2 = new SqlParameter("@Clave", u.Clave);
                SqlParameter u3 = new SqlParameter("@Nombre", u.Nombre);
                u1.SqlDbType = SqlDbType.VarChar;
                u2.SqlDbType = SqlDbType.VarChar;
                u3.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(u1);
                cmd.Parameters.Add(u2);
                cmd.Parameters.Add(u3);
                cmd.ExecuteNonQuery();

            }
        }
        public static void Editar (int codigo, Usuario u)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "UPDATE usuario SET usu_clave= @Clave, usu_nombrecompleto=@Nombre  WHERE usu_codigo=@Codigo";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter u1 = new SqlParameter("@Clave", u.Clave);
                SqlParameter u2 = new SqlParameter("@Nombre", u.Nombre);
                SqlParameter u3 = new SqlParameter("@Codigo", u.Codigo);
                u1.SqlDbType = SqlDbType.VarChar;
                u2.SqlDbType = SqlDbType.VarChar;
                u3.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(u1);
                cmd.Parameters.Add(u2);
                cmd.Parameters.Add(u3);
                cmd.ExecuteNonQuery();

            }
        }

        public static List<Usuario> ObtenerUsuarios()
        {
            Usuario usuario;
            ListaUsuario.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "SELECT * FROM usuario ORDER BY usu_codigo";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlDataReader lectordedatos = cmd.ExecuteReader();

                while (lectordedatos.Read())
                {
                    usuario = new Usuario();
                    usuario.Codigo = lectordedatos.GetString(0);
                    usuario.Clave = lectordedatos.GetString(1);
                    usuario.Nombre = lectordedatos.GetString(2);
                    usuario.UltimoAcceso = lectordedatos.GetDateTime(3);
                    

                    ListaUsuario.Add(usuario);
                }
            }

            return ListaUsuario;
        }

        public static bool Acceder(String usuario, String clave)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "SELECT * FROM usuario WHERE usu_codigo=@Usuario AND usu_clave=@Clave";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter u1 = new SqlParameter("@Usuario", usuario.Trim());
                SqlParameter u2 = new SqlParameter("@Clave", clave.Trim());
                u1.SqlDbType = SqlDbType.VarChar;
                u2.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(u1);
                cmd.Parameters.Add(u2);
                SqlDataReader lectordedatos = cmd.ExecuteReader();

                if (lectordedatos.Read())
                {
                    string ActualizarUltAcceso = "UPDATE usuario SET usu_ultacceso='" + System.DateTime.Now + "' WHERE usu_codigo='@Usuario'";
                    SqlCommand update = new SqlCommand(ActualizarUltAcceso, con);
                    SqlParameter u3 = new SqlParameter("@Usuario", usuario.Trim());
                    u3.SqlDbType = SqlDbType.VarChar;
                    update.Parameters.Add(u3);
                    update.ExecuteNonQuery();

                    LoginUsuario lu = new LoginUsuario();
                    lu.usuario = usuario.Trim();
                    LoginUsuario.Agregar(lu);
                    return true;

                }
                else
                {
                    return false;
                }

            }
        }


        public static Usuario ObtenerUsuario(string codigo)
        {
            Usuario usuario = null;
            if (ListaUsuario.Count == 0) Usuario.ObtenerUsuarios();

            foreach (Usuario u in ListaUsuario)
            {
                if (u.Codigo == codigo)
                {
                    usuario = u;
                    break;
                }
            }
            return usuario;
        }


        public override string ToString()
        {
            return Codigo;
        }
    }
}
