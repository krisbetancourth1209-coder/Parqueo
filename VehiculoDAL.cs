using System;
using System.Linq;
using ClassLibrary1;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DataAccesss
{
    public class VehiculoDAL
    {
        ParqueoVehiculosEntities db = new ParqueoVehiculosEntities();

        public void Insertar(Vehiculo v)
        {
            Vehiculos nuevo = new Vehiculos();

            nuevo.Id = v.Id;
            nuevo.Placa = v.Placa;
            nuevo.Marca = v.Marca;
            nuevo.Modelo = v.Modelo;
            nuevo.HoraEntrada = v.HoraEntrada.TimeOfDay;
            nuevo.HoraSalida = v.HoraSalida.TimeOfDay;

            db.Vehiculos.Add(nuevo);

        }

        public List<Vehiculo> ObtenerTodos()
        {
            List<Vehiculo> lista = new List<Vehiculo>();

            foreach (var item in db.Vehiculos.ToList())
            {
                Vehiculo v = new Vehiculo();
                v.Id = item.Id;
                v.Placa = item.Placa;
                v.Marca = item.Marca;
                v.Modelo = item.Modelo;
                v.HoraEntrada = DateTime.Today.Add(item.HoraEntrada);
                v.HoraSalida = DateTime.Today.Add(item.HoraSalida);

                lista.Add(v);
            }
            return lista;
        }
    }
}
