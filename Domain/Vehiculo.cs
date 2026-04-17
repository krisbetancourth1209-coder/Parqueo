using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }

        public double CalcularHoras()
        {
            TimeSpan tiempo = HoraSalida - HoraEntrada;
            return tiempo.TotalHours;
        }

        public virtual double CalcularPago()
        {
            return 0;
        }

        public virtual string MostrarResumen()
        {
            return Placa + " , " + Marca + " , " + Modelo +
               "Horas: " + CalcularHoras() +
               "Pago: " + CalcularPago();
        }
    }
}
