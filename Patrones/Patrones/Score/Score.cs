using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones {

    public interface Score {
        Score clone();

        float Progress();

        String HumanReadableString();

        bool MadeIt();
    }
}
