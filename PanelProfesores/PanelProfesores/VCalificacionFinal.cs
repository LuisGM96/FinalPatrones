using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelProfesores
{
    public abstract class VCalificacionFinal
    {
        public abstract void Aceptar(Visitor visitor);

        public double Calificacion { get; set; }

        public double IdAlumno { get; set; }
    }
}
