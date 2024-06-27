using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Draw
    {
        public int height = 60;
        public int width = 30;
        private Random random = new Random();
        public int moves;


        public List<List<int>> snakePosition = new List<List<int>>()
        {
           new() {10, 10},
        };

        public List<int> applePosition = new();
        
        public void board()
        {
            Console.Clear();
            for (int i = 5; i < height; i++)
            {
                Console.SetCursorPosition(i, 5);
                Console.Write("#");
                Console.SetCursorPosition(i, width - 1);
                Console.Write("#");
            }

            for (int i = 5; i < width; i++)
            {
                Console.SetCursorPosition(5, i);
                Console.Write("#");
                Console.SetCursorPosition(height - 1, i);
                Console.Write("#");
            }
        }

        public int clear()
        {
            snakePosition.Clear();
            snakePosition.Add(new() { 10, 10 });
            moves = 0;
            return 0;
        }

        public void snake(string direction, int score)
        {
            int x = snakePosition[0][0];
            int y = snakePosition[0][1];

            if (direction == "Right") x++;
            else if (direction == "Left") x--;
            else if (direction == "Up") y--;
            else if (direction == "Down") y++;

            snakePosition.Insert(0, new List<int> { x, y });

            if (snakePosition.Count > score +1)
            {
                snakePosition.RemoveAt(snakePosition.Count - 1);
            }

            for (int i = 0; i < snakePosition.Count; i++)
            {
                Console.SetCursorPosition(snakePosition[i][0], snakePosition[i][1]);
                Console.Write("O");
            }
        }

        public void apple(List<int> snake)
        {
            if (moves == 0)
            {
                applePosition.Add(random.Next(6, height - 1));
                applePosition.Add(random.Next(6, width - 1));
            }
            else if (snake[0] == applePosition[0] && snake[1] == applePosition[1])
            {
                applePosition.Clear();
                applePosition.Add(random.Next(6, height - 1));
                applePosition.Add(random.Next(6, width - 1));
            }

            Console.SetCursorPosition(applePosition[0], applePosition[1]); 
            Console.Write("U");
        }

        public void score(int score)
        {
            Console.SetCursorPosition(62, 0);
            Console.Write($"Score: {score}");
        }
    }
}
