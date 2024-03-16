using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_P1
{
    public class Flota
    {
        private List<Vehiculo> vehiculos;

        public Flota()
        {
            vehiculos = new List<Vehiculo>();
        }

        // Método para agregar usuarios a la lista
        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }

        // Método para mostrar la información de todos los usuarios
        public void MostrarUsuarios()
        {
            foreach (Vehiculo vehiculo in vehiculos)
            {
                vehiculo.MostrarInformacion();
                Console.WriteLine(); // Agrega una línea en blanco entre cada usuario para mejor legibilidad
            }
        }

        public void MostrarFlota()
        {
            Console.WriteLine("Información de la flota:");
            Console.WriteLine("------------------------");
            foreach (Vehiculo vehiculo in vehiculos)
            {
                vehiculo.MostrarInformacion();
                Console.WriteLine(); // Agrega una línea en blanco entre cada vehículo para mejor legibilidad
            }
        }
    }
}
