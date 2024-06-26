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
                    direction = "Up";
                    break;
                case ConsoleKey.DownArrow:
                    direction = "Down";
                    break;
                case ConsoleKey.LeftArrow:
                    direction = "Left";
                    break;
                case ConsoleKey.RightArrow:
                    direction = "Right";
                    break;
            }
            Thread.Sleep(1000);
        }
    }
}
