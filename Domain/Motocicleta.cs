using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Motocicleta : Vehiculo
    {
        public override double CalcularPago()
        {
            double tarifa = 10;
            return CalcularHoras() * tarifa;
        }
    }
}
