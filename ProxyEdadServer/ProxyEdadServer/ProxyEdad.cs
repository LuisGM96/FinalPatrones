using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyEdadServer
{
    class ProxyEdad : ProxyIEdad
    {
        public string Nombre
        {
            get
            {
                return "Esteban Julio Ricardo";
            }
        }
        public string Apellido
        {
            get
            {
                return "Montoya de la Rosa Ramírez";
            }
        }

        public string Edad
        {
            get
            {
                return "40";
            }
        }

        public string Materia
        {
            get
            {
                return "English B1";
            }
        }
    }
}
