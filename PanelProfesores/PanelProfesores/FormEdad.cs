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
    public partial class FormEdad : Form
    {
        public FormEdad()
        {
            InitializeComponent();
        }

        private void bttnEdad_Click(object sender, EventArgs e)
        {
            ProxyIEdad proxy = new ProxyEdad();

            lblNombre.Text = proxy.Nombre;
            lblEdad.Text = proxy.Edad;
            lblApellido.Text = proxy.Apellido;
            lblMateria.Text = proxy.Materia;
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
