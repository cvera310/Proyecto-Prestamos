using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public enum Cargo {Atc, Caja, Tesoreria}
    public class Personal 
    {
        public int NumeroEmpleado {get; set;}
        public Cargo Cargo {get; set;}
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Foto { get; set; }
        public string Documento { get; set; }


        public static List<Personal> ListaPersonal = new List<Personal>();

        public static void Agregar(Personal p)
        {
            ListaPersonal.Add(p);
        }

        public static void Eliminar(Personal p)
        {
            ListaPersonal.Remove(p);
        }

        public static List<Personal> ListarPersonal()
        {
            return ListaPersonal;
        }

        public override string ToString()
        {
            return this.Nombre;
        }


    }
}
