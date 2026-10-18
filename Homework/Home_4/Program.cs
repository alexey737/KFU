using System;

namespace Home_4;

class Program
{
    static void Main(string[] args)
    {
        var participants = new List<Participant>
        {
            new Human("001","Pavel",10,120,2),
            new Cat("002", "Barsik",20, 30,4),
            new Dron("003","dron",60,true),
            new MagicBall("004","Ball", 80, 100),
            new MechaSpider("005","spider", 30, true),
            new NLO("006","strange thing", 200, 0,"other galactica")

        };
        Console.WriteLine("Все участники соревнования");
        foreach (var p in participants)
            Console.WriteLine(p.GetInfo());
        Console.WriteLine("Движение");
        foreach (var p in participants)
            p.Move();
        Console.WriteLine("Летают");
        foreach (var p in participants)
            if (p is IFlyable f)
                f.Fly();
        Console.WriteLine("Плавают");
        foreach (var p in participants)
            if (p is ISwimmable s)
                s.Swim();
        Console.WriteLine("Говорят");
        foreach (var p in participants)
            if (p is ISpeakable sp)
                sp.Speak();




    }
}
