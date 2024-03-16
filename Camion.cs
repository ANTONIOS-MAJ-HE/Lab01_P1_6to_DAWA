using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_P1
{
    public class Camion: Vehiculo
    {
        public double CapacidadCarga { get; set; }

        public Camion(string marca, string modelo, int año, double capacidadCarga) : base(marca, modelo, año)
        {
            CapacidadCarga = capacidadCarga;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"CapacidadCarga: {CapacidadCarga}");
        }

        public double CalcularCostoViaje(double distancia, double costoCombustible)
        {
            // Suponemos un consumo de combustible de 2 km/l para el camión
            double consumoCombustible = distancia / 2;
            return consumoCombustible * costoCombustible;
        }
    }
}
