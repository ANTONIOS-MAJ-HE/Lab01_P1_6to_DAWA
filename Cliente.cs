using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_P1
{
    public class Cliente : Usuario
    {
        public double LitrosCargados { get; set; }

        // Constructor que llama al constructor de la clase base
        public Cliente(string nombres, double saldo, double litrosCargados) : base(nombres, saldo)
        {
            LitrosCargados = litrosCargados;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Litros Cargados: {LitrosCargados}");
        }
    }
}
