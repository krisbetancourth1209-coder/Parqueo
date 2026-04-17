using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Automovil : Vehiculo
    {
        public override double CalcularPago()
        {
            double tarifa = 20;
            return CalcularHoras() * tarifa;
        }
    }
}
