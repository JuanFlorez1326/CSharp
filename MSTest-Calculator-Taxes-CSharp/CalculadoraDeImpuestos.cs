using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImpuestostest
{
    internal class CalculadoraDeImpuestos
    {
        public decimal ObtenerIva(decimal montoreserva)    
        {
            //const decimal porcentaje = 0.19m;
            //decimal ivaReserva = porcentaje * montoreserva;
            return 0.19m * montoreserva;
        }

        public decimal Estatal(decimal montoreserva)
        {
            //const decimal impuesto = 0.03m;
            //decimal impuestoReserva = impuesto * montoreserva;
            return 0.03m * montoreserva;
        }

        public decimal Reserva ( decimal montoreserva)
        {
            //const decimal porcentaje = 0.19m;
            //const decimal impuesto = 0.03m;
            //decimal masIva = porcentaje * montoreserva;
            //decimal masImpuesto = impuesto * montoreserva;
            //decimal TotalReserva = masIva + masImpuesto + montoreserva;
            //return masIva + masImpuesto + montoreserva;
            return (0.19m * montoreserva) + (0.03m * montoreserva) + montoreserva;
        }
     }
}
