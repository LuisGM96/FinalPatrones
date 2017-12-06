using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones {
    class DragAndDropAttempt : GameAttempt {
        public List<string> wrongWords { get; set; }

        public override String Details() {
            if (wrongWords.Count == 0) {
                return "No wrong guesses";
            }

            String res = "Guessed wrong in: ";
            for (int i = 0; i < wrongWords.Count - 1; i ++) {
                res += wrongWords[i] + ", ";
            }
            res += wrongWords[wrongWords.Count - 1];
            return res;
        }
    }
}
