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
    public partial class FormSubirNiveles : Form
    {
        public FormSubirNiveles()
        {
            InitializeComponent();
        }

        private void btn_LvlAlumnos_Click(object sender, EventArgs e)
        {
            DPuntosAlumno Alumno1 = new DPuntosBaseAlumno();
            Alumno1 = new DPuntosMatematicas(Alumno1);
            Alumno1 = new DPuntosColores(Alumno1);

            var puntos = Alumno1.CalcularPuntos();

            label1.Text ="los puntos necesarios para subir de nivel para el alumno 1 son " +  puntos.ToString();

        }

        private void FormSubirNiveles_Load(object sender, EventArgs e)
        {

        }
    }
}
