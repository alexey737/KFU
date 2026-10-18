using System;
using System.Collections.Generic;
using System.Text;

namespace Home_4;
public class Human: Participant, ISpeakable, ISwimmable
{
    public int Intelligence;
    public int Legs;
    public Human(string id, string name, double speed, int iq, int legs)
        :base(id, name, speed)
    {
        Intelligence = iq;
        Legs = legs;
    }
    public override void Move() => Console.WriteLine($"{Name} уверенно ходит");
    public void Swim() => Console.WriteLine($"{Name} уверенно плавает");
    public void Speak() => Console.WriteLine($"{Name} уверенно говорит");
    public override string GetInfo()
    {
        return base.GetInfo() + $", интеллект: {Intelligence}, ноги: {Legs}";
    }
}