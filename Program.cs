// See https://aka.ms/new-console-template for more information
using Lab01_P1;

//Console.WriteLine("Hello, World!");

//Persona persona = new Persona();
//persona.nombres = "Antonio Jairo";
//persona.apellidos = "Santiago Masgo";
//persona.edad = 20;

//string NombresCompletos = persona.getnombrescompletos();
//Console.WriteLine(NombresCompletos);
//Console.Read();


//public virtual void MostrarInformacion()
//{
//    Console.WriteLine($"Nombre: {Nombres}");
//    Console.WriteLine($"Saldo: {Saldo}");
//}

using System;

using System;

class Program
{
    //static void Main(string[] args)
    //{
    //    Grifo grifo = new Grifo(); // Creamos una instancia de la clase Grifo

    //    // Ciclo para mostrar el menú hasta que el usuario decida salir
    //    bool salir = false;
    //    while (!salir)
    //    {
    //        // Mostrar el menú de opciones
    //        Console.WriteLine("\nMenú de opciones:");
    //        Console.WriteLine("1. Mostrar información de usuarios");
    //        Console.WriteLine("2. Agregar cliente");
    //        Console.WriteLine("3. Agregar empleado");
    //        Console.WriteLine("4. Salir");
    //        Console.Write("Seleccione una opción: ");

    //        // Leer la opción ingresada por el usuario
    //        string opcion = Console.ReadLine();

    //        // Ejecutar la opción seleccionada
    //        switch (opcion)
    //        {
    //            case "1":
    //                Console.WriteLine("\nInformación de usuarios:");
    //                grifo.MostrarUsuarios();
    //                break;
    //            case "2":
    //                Console.Write("\nIngrese el nombre del cliente: ");
    //                string nombreCliente = Console.ReadLine();
    //                Console.Write("Ingrese el saldo del cliente: ");
    //                double saldoCliente = Convert.ToDouble(Console.ReadLine());
    //                Console.Write("Ingrese los litros cargados del cliente: ");
    //                double litrosCargadosCliente = Convert.ToDouble(Console.ReadLine());
    //                Cliente cliente = new Cliente(nombreCliente, saldoCliente, litrosCargadosCliente);
    //                grifo.AgregarUsuario(cliente);
    //                Console.WriteLine("Cliente agregado correctamente.\n");
    //                break;
    //            case "3":
    //                Console.Write("\nIngrese el nombre del empleado: ");
    //                string nombreEmpleado = Console.ReadLine();
    //                Console.Write("Ingrese el saldo del empleado: ");
    //                double saldoEmpleado = Convert.ToDouble(Console.ReadLine());
    //                Console.Write("Ingrese el sueldo del empleado: ");
    //                double sueldoEmpleado = Convert.ToDouble(Console.ReadLine());
    //                Empleado empleado = new Empleado(nombreEmpleado, saldoEmpleado, sueldoEmpleado);
    //                grifo.AgregarUsuario(empleado);
    //                Console.WriteLine("Empleado agregado correctamente.\n");
    //                break;
    //            case "4":
    //                salir = true;
    //                Console.WriteLine("\nSaliendo del programa...");
    //                break;
    //            default:
    //                Console.WriteLine("\nOpción no válida. Por favor, seleccione una opción válida.\n");
    //                break;
    //        }
    //    }
    //}

    //parte 2

    static void Main(string[] args)
    {
        // Crear objetos de tipo Automovil y Camion
        Automovil automovil = new Automovil("Toyota", "Corolla", 2022, "Gasolina");
        Camion camion = new Camion("Volvo", "FH16", 2020, 20000.0);

        // Crear una flota y agregar los vehículos
        Flota flota = new Flota();
        flota.AgregarVehiculo(automovil);
        flota.AgregarVehiculo(camion);

        // Mostrar información de la flota
        flota.MostrarFlota();

        // Crear lista de vehículos
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        // Agregar vehículos a la lista
        vehiculos.Add(automovil);
        vehiculos.Add(camion);

        // Implementar el programa principal con el menú de opciones
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1. Mostrar información de vehículos");
            Console.WriteLine("2. Calcular costo de viaje");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("\nInformación de vehículos:");
                    foreach (Vehiculo vehiculo in vehiculos)
                    {
                        vehiculo.MostrarInformacion();
                        Console.WriteLine(); // Agrega una línea en blanco entre cada vehículo
                    }
                    break;
                case "2":
                    // Pedir al usuario la distancia del viaje y el costo del combustible
                    Console.Write("\nIngrese la distancia del viaje (en km): ");
                    double distancia = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el costo del combustible por litro: ");
                    double costoCombustible = Convert.ToDouble(Console.ReadLine());

                    // Calcular el costo de viaje para cada vehículo y mostrarlo
                    Console.WriteLine("\nCosto de viaje:");
                    foreach (Vehiculo vehiculo in vehiculos)
                    {
                        double costoViaje = 0.0;
                        if (vehiculo is Automovil)
                        {
                            Automovil auto = (Automovil)vehiculo;
                            costoViaje = auto.CalcularCostoViaje(distancia, costoCombustible);
                        }
                        else if (vehiculo is Camion)
                        {
                            Camion truck = (Camion)vehiculo;
                            costoViaje = truck.CalcularCostoViaje(distancia, costoCombustible);
                        }
                        Console.WriteLine($"- {vehiculo.Marca} {vehiculo.Modelo}: ${costoViaje:F2}");
                    }
                    break;
                case "3":
                    salir = true;
                    Console.WriteLine("\nSaliendo del programa...");
                    break;
                default:
                    Console.WriteLine("\nOpción no válida. Por favor, seleccione una opción válida.\n");
                    break;
            }
        }
    }
}