using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Cliente : Persona
    {
        public int NumeroCliente {get; set;}
        public String LugarTrabajo {get; set;}
        public int AntiguedadLaboral {get; set;}
        public Boolean Informconf {get; set;}
        
        public Cliente (){}
    }
}
