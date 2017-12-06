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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calificaciones_Click(object sender, EventArgs e)
        {
            FormCalificaciones formCalificaciones = new FormCalificaciones();
            formCalificaciones.Show();
        }

        private void bttnInfoProf_Click(object sender, EventArgs e)
        {
            FormEdad myForm = new FormEdad();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void bttnTerminados_Click(object sender, EventArgs e)
        {
            FormMediator myForm = new FormMediator();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btn_niveles_Click(object sender, EventArgs e)
        {
        

            FormSubirNiveles formSubirNiveles = new FormSubirNiveles();
            formSubirNiveles.Show();
        }
    }
}
