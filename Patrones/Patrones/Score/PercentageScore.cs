using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones {
    public class PercentageScore : Score {

        public float Percentage { get; set; }

        public PercentageScore() {
            Percentage = 0;
        }

        public PercentageScore(float _percentage) {
            Percentage = _percentage;
        }
        
        public Score clone() {
            return new PercentageScore(Percentage);
        }

        public float Progress() {
            return Percentage;
        }

        public String HumanReadableString() {
            return String.Format("{0:f2}%", Percentage);
        }

        public bool MadeIt() {
            return Percentage == 100.0;
        }
    }
}
