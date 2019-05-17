using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public enum EstadoPrestamo { Pagado, No_pagado }
    public class PrestamoDetalle : Prestamo
    {
        public int NroCuota;
        public double MontoDetalle;
        public double SaldoDetalle;
        public DateTime Vencimiento;
        public EstadoPrestamo estado;

        public static List<PrestamoDetalle> ListaPrestamoDetalle = new List<PrestamoDetalle>();
        
        public static void Agregar(PrestamoDetalle pd)
        {
            ListaPrestamoDetalle.Add(pd);
        }

        public static void Eliminar (PrestamoDetalle pd)
        {
            ListaPrestamoDetalle.Remove(pd);
        }

        public static List<PrestamoDetalle> ObtenerPrestamoDetalle()
        {
            return ListaPrestamoDetalle;
        }
    }
}
