using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyEdadServer
{
    interface ProxyIEdad
    {
        string Nombre { get; }
        string Apellido { get; }
        string Edad { get; }
        string Materia { get; }
    }
}
