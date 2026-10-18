using System;
using System.Collections.Generic;
using System.Text;

namespace Home_4;
public class MagicBall: Participant, IFlyable, ISpeakable
{
    public int MagicPower;
    public MagicBall(string id, string name, double speed, int mp)
        : base(id, name, speed)
    {
        MagicPower = mp;
    }
    public override void Move() => Console.WriteLine($"{Name} может летать и катиться");
    public void Fly() => Console.WriteLine($"{Name} летает и светится магией");
    public void Speak() => Console.WriteLine($"{Name} общается телепатией");
    public override string GetInfo()
    {
        return base.GetInfo() + $", магическая сила: {MagicPower}";
    }
}

