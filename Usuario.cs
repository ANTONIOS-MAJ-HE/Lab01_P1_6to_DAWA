using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_P1
{
    public class Usuario
    {
        public string Nombres { get; set; }
        public double Saldo { get; set; }

        public Usuario(string nombres, double saldo)
        {
            Nombres = nombres;
            Saldo = saldo;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombres}");
            Console.WriteLine($"Saldo: {Saldo}");
        }
    }
}
