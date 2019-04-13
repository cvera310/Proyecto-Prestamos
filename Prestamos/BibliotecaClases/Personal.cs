using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public enum Cargo {Atc, Caja, Tesoreria}
    public class Personal : Persona
    {
        public int NumeroEmpleado {get; set;}
        public Cargo cargo {get; set;}

        public Personal(){}


    }
}
