using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_P1
{
    public class Grifo
    {
        private List<Usuario> usuarios;

        public Grifo()
        {
            usuarios = new List<Usuario>();
        }

        // Método para agregar usuarios a la lista
        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        // Método para mostrar la información de todos los usuarios
        public void MostrarUsuarios()
        {
            foreach (Usuario usuario in usuarios)
            {
                usuario.MostrarInformacion();
                Console.WriteLine(); // Agrega una línea en blanco entre cada usuario para mejor legibilidad
            }
        }
    }
}
