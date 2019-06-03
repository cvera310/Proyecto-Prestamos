using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class LoginUsuario
    {
        public String usuario {get; set;}
        
        public static List<LoginUsuario> ListaUsuario = new List<LoginUsuario>();
        
        public static void Agregar(LoginUsuario lu)
        {
            ListaUsuario.Add(lu);
        }

        public static List<LoginUsuario> ObtenerUsuario()
        {
            return ListaUsuario;
        }

        public static string UsuarioConectado()
        {
             String usuarioconectado = null;
            foreach (LoginUsuario usu in LoginUsuario.ListaUsuario)
            {
                usuarioconectado = $"{usu}";
            }
            return usuarioconectado;
        }
    public override string ToString()
        {
            return usuario;
        }

    }

}
