using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patrones {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void spaceShipButton_Click(object sender, EventArgs e) {
            presentForm(AbstractGameAttemptFactory.GameType.SPACE_SHIP);
        }

        private void dragAndDropButton_Click(object sender, EventArgs e) {
            presentForm(AbstractGameAttemptFactory.GameType.DRAG_AND_DROP);
        }

        private void presentForm(AbstractGameAttemptFactory.GameType gameType) {
            Hide();
            GameAttemptsForm form = new GameAttemptsForm(gameType);
            form.Closed += (s, args) => Show();
            form.Show();
        }
    }
}
