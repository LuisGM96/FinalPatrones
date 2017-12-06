using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelProfesores
{
    public class VPuntosExtra
    {
        private List<VCalificacionFinal> calificaciones = new List<VCalificacionFinal>();

        public void Agregar(VCalificacionFinal califiacion)
        {
            this.calificaciones.Add(califiacion);
        }

        public void Quitar(VCalificacionFinal califiacion)
        {
            this.calificaciones.Remove(califiacion);
        }

        public void Aceptar(Visitor visitor)
        {
            foreach (var calificacion in this.calificaciones)
            {
                calificacion.Aceptar(visitor);
            }
        }
    }
}
