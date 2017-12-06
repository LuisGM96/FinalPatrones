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
    public partial class FormMediator : Form
    {
        public FormMediator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MedIMediator mediator = new MedConcreteMediator();
            MedIParticipant participant1 = new MedConcreteParticipant1(mediator);
            MedIParticipant participant2 = new MedConcreteParticipant2(mediator);
            MedIParticipant participant3 = new MedConcreteParticipant3(mediator);
            MedIParticipant participant4 = new MedConcreteParticipant4(mediator);

            mediator.AddParticipant(participant1);
            mediator.AddParticipant(participant2);
            mediator.AddParticipant(participant3);
            mediator.AddParticipant(participant4);

            
            label1.Text = participant1.SendMessage("Jorge");
            //System.Threading.Thread.Sleep(5000);
            label2.Text = participant2.SendMessage("David");
            label3.Text = participant1.SendMessage("Luis");
            //System.Threading.Thread.Sleep(2000);
            label4.Text = participant2.SendMessage("Diego");
        }
    }
}
