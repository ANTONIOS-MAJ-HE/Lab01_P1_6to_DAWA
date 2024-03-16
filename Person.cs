using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_P1
{
    public class Persona
    {
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int edad { get; set; }

        public string getnombrescompletos()
        {
            return nombres + "" + apellidos;
        }

        public bool esmayoredad()
        {
            return edad > 18;
        }
    }

    

    

    


}
