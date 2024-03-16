using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_P1
{
    public class Automovil : Vehiculo
    {
        public string Combustible { get; set; }

        // Constructor que llama al constructor de la clase base
        public Automovil(string marca, string modelo, int año, string combustible) : base(marca, modelo, año)
        {
            Combustible = combustible;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Combustible: {Combustible}");
        }

        public double CalcularCostoViaje(double distancia, double costoCombustible)
        {
            // Suponemos un consumo de combustible de 10 km/l para el automóvil
            double consumoCombustible = distancia / 10;
            return consumoCombustible * costoCombustible;
        }
    }
}
