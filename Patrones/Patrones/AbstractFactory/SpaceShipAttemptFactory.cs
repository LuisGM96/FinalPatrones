using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones {
    class SpaceShipAttemptFactory : AbstractGameAttemptFactory {
        private static PercentageScore score = new PercentageScore();

        public override Score createScore(List<object> data) {
            PercentageScore newScore = (PercentageScore)score.clone();
            int wat = Convert.ToInt32(data[2]);
            newScore.Percentage = (float)(Convert.ToDouble(data[2]) / Convert.ToDouble(data[3]) * 100.0) ;
            return newScore;
        }

        public override GameAttempt createAttempt(List<object> data) {
            SpaceShipAttempt attempt = new SpaceShipAttempt();
            attempt.User = (string)data[0];
            attempt.Timestamp = (DateTime)data[1];
            attempt.LastPosition = (float)Convert.ToDouble(data[2]);
            return attempt;
        }
    }
}
