using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{

    public enum Sexo
    {
        Masculino,
        Femenimo,
        NoDefinido
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
        public String Cedula { get; set; }
        public String RazonSocial { get; set; }


        public String Nacimiento { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }
        public String Foto { get; set; }

        public String LugarTrabajo { get; set; }
        public int AntiguedadLaboral { get; set; }
        public Boolean Informconf { get; set; }

        public static List<Cliente> ListaCliente = new List<Cliente>();

        public static void Agregar(Cliente c)
        {
            ListaCliente.Add(c);
        }

        public static void Eliminar(Cliente c)
        {
            ListaCliente.Remove(c);
        }

        public static List<Cliente> ListarCliente()
        {
            return ListaCliente;
        }

        public override string ToString()
        {
            return NumeroCliente + ", " + RazonSocial;
        }
    }
}
