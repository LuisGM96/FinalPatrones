using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones {
    class DragAndDropAttemptFactory : AbstractGameAttemptFactory {
        private static CorrectAnswersScore score = new CorrectAnswersScore();

        public override Score createScore(List<object> data) {
            CorrectAnswersScore newScore = (CorrectAnswersScore)score.clone();
            newScore.CorrectAnswers = (int)data[2];
            newScore.TotalAnswers = (int)data[3];
            return newScore;
        }

        public override GameAttempt createAttempt(List<object> data) {
            DragAndDropAttempt attempt = new DragAndDropAttempt();
            attempt.User = (string)data[0];
            attempt.Timestamp = (DateTime)data[1];
            attempt.wrongWords = (List<string>)data[4];
            return attempt;
        }
    }
}
