using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelProfesores
{
    public partial class FormCalificaciones : Form
    {
        public FormCalificaciones()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_VerCalificaciones_Click(object sender, EventArgs e)
        {
            VPuntosExtra calcular = new VPuntosExtra();
            //VEstudianteCuarto cuarto = new VEstudianteCuarto();

            VMatematicas luis = new VMatematicas { IdAlumno = 0183163, Calificacion = 8 };
            VMatematicas diego = new VMatematicas { IdAlumno = 0183245, Calificacion = 9 };

            VColores jorge = new VColores { IdAlumno = 0183543, Calificacion = 7 };
            VColores david = new VColores { IdAlumno = 0183566, Calificacion = 6 };

            calcular.Agregar(luis);
            calcular.Agregar(diego);
            calcular.Agregar(jorge);
            calcular.Agregar(david);

            string a = string.Format("la calificacion del alumno {1} es de  {0}", jorge.Calificacion * 0.60, jorge.IdAlumno);
            lPuntaje.Text = a;

            string b = string.Format("la calificacion del alumno {1} es de  {0}", luis.Calificacion * 0.60, luis.IdAlumno);
            label2.Text = b;

            string c = string.Format("la calificacion del alumno {1} es de  {0}", david.Calificacion * 0.60, david.IdAlumno);
            label3.Text = c; 


        }
    }
}
