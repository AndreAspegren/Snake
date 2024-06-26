using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Check
    {
        public bool collision(List<List<int>> position, int height, int width)
        {
            for(var i = 1; i < position.Count; i++)
            {
                if (position[0][0] == position[i][0] && position[0][1] == position[i][1]) return true;
            }
            return position[0][0] >= width * 2 -1 || position[0][1] == height || position[0][0] == 5 || position[0][1] == 5;
        }

        public bool apple(int applex, int appley, List<int> snake)
        {
            return applex == snake[0] && appley == snake[1];
        }
    }
}
