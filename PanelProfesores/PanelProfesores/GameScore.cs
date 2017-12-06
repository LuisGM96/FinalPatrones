using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelProfesores
{
    public class GameScore
    {
        public int minTime, maxTime;
        public int calculate(int time)
        {
            int ans = 100 - ((time - minTime) / (maxTime - minTime)) * 100;
            ans = Math.Min(Math.Max(ans, 0), 100);
            return ans;
        }
    }
}
