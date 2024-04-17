using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_II
{
    public class Persona
    {

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Dni { get; set; }

        public DateTime Fecha_nac { get; set; }


        public void Agregar(string aNombre,
            string aApellido,
            int aDni, DateTime aFecha_nac
            )


        {
            Nombre = aNombre;
            Apellido = aApellido;
            Dni = aDni;
            Fecha_nac = aFecha_nac;
        }
    }
}
