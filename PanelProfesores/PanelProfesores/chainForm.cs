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
    public partial class chainForm : Form
    {
        Alumno[] a;
        Evaluador evaluador;
        public chainForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = evaluador.calificar(a[comboBox1.SelectedIndex].calificacion);
        }

        private void chainForm_Load(object sender, EventArgs e)
        {

            evaluador = new Evaluador();
            a = new Alumno[4];
            a[0] = new Alumno();
            a[0].id = 1;
            a[0].calificacion = 3;
            a[1] = new Alumno();
            a[1].id = 2;
            a[1].calificacion = 7;
            a[2] = new Alumno();
            a[2].id = 3;
            a[2].calificacion = 8;
            a[3] = new Alumno();
            a[3].id = 4;
            a[3].calificacion = 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
