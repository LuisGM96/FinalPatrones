using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Constrols;

namespace PanelProfesores
{
    public partial class FormBuilder : Form
    {
        public FormBuilder()
        {
            InitializeComponent();
        }

        private void addTestTimeButton_Click(object sender, EventArgs e)
        {
            string testTime = testTimesTextBox.Text;
            int val;
            if (Int32.TryParse(testTime, out val))
            {
                testTimesListBox.Items.Add(new ListBoxItem(val, val));
            }
        }
    }
}
