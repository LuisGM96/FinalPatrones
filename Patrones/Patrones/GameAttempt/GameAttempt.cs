using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones {
    public abstract class GameAttempt {

        public DateTime Timestamp { get; set; }

        public String User { get; set; }

        public abstract String Details();
    }
}
