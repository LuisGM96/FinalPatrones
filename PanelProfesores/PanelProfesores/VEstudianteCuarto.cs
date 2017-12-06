using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelProfesores
{
    class VEstudianteCuarto : Visitor
    {
        public override void CalcularColoresCal(VColores colores)
        {
            Console.WriteLine("la calificacion del alumno {1} es de  {0}", colores.Calificacion * 0.60, colores.IdAlumno);
            string a = string.Format("la calificacion del alumno {1} es de  {0}", colores.Calificacion * 0.60, colores.IdAlumno);
        }

        public override void CalcularMateCal(VMatematicas matematicas)
        {
            Console.WriteLine("la calificacion del alumno {1} es de {0}", matematicas.Calificacion * 0.70, matematicas.IdAlumno);
        }
    }
}
