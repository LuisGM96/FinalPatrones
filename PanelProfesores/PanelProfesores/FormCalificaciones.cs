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

            VMatematicas luis = new VMatematicas { IdAlumno = 0183163, Calificacion = 8 };
            VMatematicas diego = new VMatematicas { IdAlumno = 0183245, Calificacion = 9 };

            VColores jorge = new VColores { IdAlumno = 0183543, Calificacion = 7 };
            VColores david = new VColores { IdAlumno = 0183566, Calificacion = 6 };

            calcular.Agregar(luis);
            calcular.Agregar(diego);
            calcular.Agregar(jorge);
            calcular.Agregar(david);
        }
    }
}
