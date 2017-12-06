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
    public partial class GameAttemptsForm : Form {
        AbstractGameAttemptFactory.GameType gameType;
        private Random random = new Random();

        public GameAttemptsForm() {
            InitializeComponent();
        }

        public GameAttemptsForm(AbstractGameAttemptFactory.GameType gameType) : this() {
            this.gameType = gameType;
            gameTitle.Text = (gameType == AbstractGameAttemptFactory.GameType.DRAG_AND_DROP) ? "Drag and Drop" : "Space Ship";

            AbstractGameAttemptFactory factory = AbstractGameAttemptFactory.getFactory(gameType);
            foreach (List<object> list in getData()) {
                GameAttempt attempt = factory.createAttempt(list);
                Score score = factory.createScore(list);
                dataGrid.Rows.Add(attempt.User, attempt.Timestamp, score.MadeIt() ? "Yes" : "No", score.HumanReadableString(), attempt.Details());
            }
        }

        private List<List<object>> getData() {
            // TODO: Get proper data from database

            List<List<object>> data = new List<List<object>>();
            if (gameType == AbstractGameAttemptFactory.GameType.DRAG_AND_DROP) {
                data.Add(new List<object>() { "Jorge Ramirez", randomDate(), 4, 5, new List<string>() { "Blue" } });
                data.Add(new List<object>() { "Jorge Ramirez", randomDate(), 5, 7, new List<string>() { "Red", "Orange" } });
                data.Add(new List<object>() { "Luis Mata", randomDate(), 4, 5, new List<string>() { "Blue" } });
                data.Add(new List<object>() { "Jorge Ramirez", randomDate(), 3, 6, new List<string>() { "Red", "Green", "Blue" } });
                data.Add(new List<object>() { "Caro Delgadillo", randomDate(), 6, 6, new List<string>() });
                data.Add(new List<object>() { "Caro Delgadillo", randomDate(), 5, 5, new List<string>() });
                data.Add(new List<object>() { "Rodrigo Reyes", randomDate(), 0, 3, new List<string>() { "Blue", "Yellow", "Purple" } });
            } else {
                data.Add(new List<object>() { "Caro Delgadillo", randomDate(), 865.0, 865.0 });
                data.Add(new List<object>() { "Jorge Ramirez", randomDate(), 6433.0, 21426.0 });
                data.Add(new List<object>() { "Luis Mata", randomDate(), 644.0, 755.0 });
                data.Add(new List<object>() { "Jorge Ramirez", randomDate(), 414.0, 500.0 });
                data.Add(new List<object>() { "Rodrigo Reyes", randomDate(), 0.0, 6246.0 });
                data.Add(new List<object>() { "Caro Delgadillo", randomDate(), 36.0, 36.0 });
                data.Add(new List<object>() { "Jorge Ramirez", randomDate(), 535.0, 757.0 });
            }
            return data;
        }

        private DateTime randomDate() {
            DateTime date = DateTime.Today;
            date = date.AddMinutes(-(random.NextDouble() * 9000 - 1000));
            return date;
        }
    }
}
