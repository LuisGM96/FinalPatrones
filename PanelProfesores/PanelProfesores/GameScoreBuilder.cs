using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelProfesores
{
    class GameScoreBuilder
    {
        public static GameScore build(List<int> times)
        {
            GameScore ans = new GameScore();
            ans.maxTime = times.Max();
            ans.minTime = times.Min();
            return ans;
        }
    }
}
