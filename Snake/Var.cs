using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Var
    {
        public int score = 0;
        public string direction = "Right";

        public void key()
        {

            var key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    direction = direction != "Down" ? "Up" :  direction;
                    break;
                case ConsoleKey.DownArrow:
                    direction = direction != "Up" ? "Down" : direction;
                    break;
                case ConsoleKey.LeftArrow:
                    direction = direction != "Right" ? "Left" : direction;
                    break;
                case ConsoleKey.RightArrow:
                    direction = direction != "Left" ? "Right" : direction;
                    break;
            }
            Thread.Sleep(1000);
        }
    }
}
