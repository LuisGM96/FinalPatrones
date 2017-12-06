using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones {
    public class CorrectAnswersScore : Score {

        public int CorrectAnswers { get; set; }
        public int TotalAnswers { get; set; }

        public CorrectAnswersScore() {
            CorrectAnswers = 0;
            TotalAnswers = 0;
        }

        public CorrectAnswersScore(int correct, int total) {
            CorrectAnswers = correct;
            TotalAnswers = total;
        }

        public CorrectAnswersScore(int total) {
            CorrectAnswers = 0;
            TotalAnswers = total;
        }

        public Score clone() {
            return new CorrectAnswersScore(0, TotalAnswers);
        }

        public float Progress() {
            return CorrectAnswers / TotalAnswers;
        }

        public String HumanReadableString() {
            return String.Format("{0}/{1}", CorrectAnswers, TotalAnswers);
        }

        public bool MadeIt() {
            return CorrectAnswers == TotalAnswers;
        }
    }
}
