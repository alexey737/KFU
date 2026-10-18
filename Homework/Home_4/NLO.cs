using System;
using System.Collections.Generic;
using System.Text;

namespace Home_4;

public class NLO: Participant, IFlyable, ISpeakable, ISwimmable
{
    public string Origin;
    public NLO(string id, string name, double speed, int iq, string origin)
        : base(id, name, speed)
    {
        Origin = origin;
       
    }
    public override void Move() => Console.WriteLine($"{Name} непонятно перемещается");
    public void Swim() => Console.WriteLine($"{Name} маскируется в воде");
    public void Speak() => Console.WriteLine($"{Name} издает непонятные звуки");
    public void Fly() => Console.WriteLine($"{Name} свободно летает");
    public override string GetInfo()
    {
        return base.GetInfo() + $", происхождение: {Origin}";
    }
}
