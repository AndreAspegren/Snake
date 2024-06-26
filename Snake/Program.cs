using Snake;

var show = new Draw();
var check = new Check();
var var = new Var();

run();
void run()
{
        Console.Clear();
        Console.WriteLine("Trykk en knapp for å starte");
        Console.ReadKey();
        var.score = show.clear();
        var.direction = "Right";
        while (true)
        {
            Console.Clear();
            show.board();
            show.apple(show.snakePosition[0]);
            show.score(var.score);
            var worker = new Thread(() => var.key());
            worker.Start();
            show.snake(var.direction, var.score);
            if (check.collision(show.snakePosition, show.height / 2 - 1, show.width)) break;
            if (check.apple(show.applePosition[0], show.applePosition[1], show.snakePosition[0])) var.score++;
            show.moves++;
            Thread.Sleep(100 - (var.score * 2 < 96 ? var.score * 2 : 96));
        }
        Console.SetCursorPosition(62, 2);
        if (var.score < 3481) Console.Write("Du tapte!");
        else Console.Write("Du vant!");
}