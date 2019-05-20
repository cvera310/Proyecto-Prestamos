using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class EvaluacionCredito
    {
        public enum TipoPago
        {
            Mensual,
            Quincenal,
            Jornal
        }

        public Cliente cliente { get; set; }

        public int Alimentacion { get; set; }
        public int Alquiler { get; set; }
        public int ServiciosBasicos { get; set; }
        public int Transporte { get; set; }
        public int Otros { get; set; }
        public int TotalEgresos { get; set; }
        public int Salario { get; set; }
        public int TotalIngresos { get; set; }
        public TipoPago tipo_pago { get; set; }
        public int IngresoExtra { get; set; }

        public static List<EvaluacionCredito> listaEvaluacion = new List<EvaluacionCredito>();


        public static void Agregar(EvaluacionCredito ec)
        {
            listaEvaluacion.Add(ec);
        }

        public static void Eliminar(EvaluacionCredito ec)
        {
            listaEvaluacion.Remove(ec);
        }

        public static List<EvaluacionCredito> Obtener()
        {
            return listaEvaluacion;
        }

        



    }
}
