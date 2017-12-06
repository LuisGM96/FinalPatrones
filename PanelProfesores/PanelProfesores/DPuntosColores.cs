using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelProfesores
{
    public class DPuntosColores : DComponentDecorator
    {
        private DPuntosAlumno currentAlumno;

        public DPuntosColores(DPuntosAlumno puntos)
        {
            this.currentAlumno = puntos;
        }

        public override int CalcularPuntos()
        {
            return this.currentAlumno.CalcularPuntos() + 10;
        }
    }
}
