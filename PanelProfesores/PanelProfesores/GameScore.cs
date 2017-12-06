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
            if (maxTime - minTime != 0)
            {
                int ans = 100 - (((time - minTime) * 100) / (maxTime - minTime));
                ans = Math.Min(Math.Max(ans, 0), 100);
                return ans;
            } else
            {
                return 100;
            }
        }
    }
}
