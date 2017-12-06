using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patrones;

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

        private void historyButton_Click(object sender, EventArgs e) {
            Hide();
            Patrones.Form1 form = new Patrones.Form1();
            form.Closed += (s, args) => Show();
            form.Show();
        }
            
        private void btn_niveles_Click(object sender, EventArgs e)
        {
            FormSubirNiveles formSubirNiveles = new FormSubirNiveles();
            formSubirNiveles.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBuilder myForm = new FormBuilder();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chainForm myForm = new chainForm();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
