using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelProfesores
{
    public abstract class Visitor
    {
        public abstract void CalcularColoresCal(VColores colores);

        public abstract void CalcularMateCal(VMatematicas matematicas);
    }
}
