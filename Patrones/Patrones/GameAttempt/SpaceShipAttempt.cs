using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones {
    public class SpaceShipAttempt : GameAttempt {

        public float LastPosition { get; set; }

        public override string Details() {
            return String.Format("Advanced {0:f2} kilometers", LastPosition);
        }
    }
}
