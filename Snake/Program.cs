using Snake;

run();
void run()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Trykk en knapp for å starte");
        Console.ReadKey();
        var draw = new Draw();
        var check = new Check();
        var var = new Var();
        while (true)
        {
            Console.Clear();
            draw.board();
            draw.apple(draw.snakePosition[0]);
            draw.score(var.score);
            var worker = new Thread(() => var.key());
            worker.Start();
            draw.snake(var.direction, var.score);
            if (check.collision(draw.snakePosition, draw.height / 2 - 1, draw.width)) break;
            if (check.apple(draw.applePosition[0], draw.applePosition[1], draw.snakePosition[0])) var.score++;
            draw.moves++;
            Thread.Sleep(100 - (var.score * 2 < 96 ? var.score * 2 : 96));
        }

        Console.SetCursorPosition(62, 2);
        if (var.score < 3481) Console.Write("Du tapte!");
        else Console.Write("Du vant!");
        Console.SetCursorPosition(62, 4);
        Console.Write("Trykk ja for å begynne på nytt, hva som helst annet for å avslutte");
        Console.SetCursorPosition(62, 5);
        if (Console.ReadLine() != "ja") break;
    }
}