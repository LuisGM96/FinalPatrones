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
    public partial class FormBuilder : Form
    {
        GameScore g = null;
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
                testTimesListBox.Items.Add(val);
            }
            if (testTimesListBox.Items.Count > 0)
            {
                createGameScoreButton.Enabled = true;
            }
        }

        private void createGameScoreButton_Click(object sender, EventArgs e)
        {
            g = GameScoreBuilder.build(testTimesListBox.Items.Cast<int>().ToList());
            calTimeButton.Enabled = true;
        }

        private void calTimeButton_Click(object sender, EventArgs e)
        {
            string calTime = calTimeTextBox.Text;
            int val, s;
            if (Int32.TryParse(calTime, out val))
            {
                s = g.calculate(val);
                score.Text = "Puntos: " + s.ToString();
            }
        }
    }
}
