using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelProfesores
{
    public class DAlumnoSegundo : DPuntosAlumno
    {
        private int PuntosMate = 20;
        private int PuntosColores = 15;
        private int PuntosCasa = 30;

        public override int CalcularPuntos()
        {
            var total = this.PuntosMate + this.PuntosColores + this.PuntosCasa;

            return total;
        }
    }
}
