using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{


    
    public class DetalleIngresos

    {

        public enum TipoIngreso
        {
            Salario_Mensual,
            Salario_Quincenal,
            Ingreso_Extra,
            Jornales


        }

        public TipoIngreso tipo_ingreso { get; set; }
        public double monto_ingreso { get; set; }


    }
}
