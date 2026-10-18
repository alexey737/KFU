using System;
using System.Collections.Generic;
using System.Text;

namespace Home_4;
public class Dron : Participant, IFlyable
{
    public bool Battery;
    public Dron(string id, string name, double speed, bool battery)
        : base(id, name, speed)
    {
        Battery = battery;
    }
    public override void Move() => Console.WriteLine($"{Name} быстро летает");
    public void Fly() => Console.WriteLine($"{Name} умеет летать");
    public override string GetInfo()
    {
        return base.GetInfo() + $"Батарейка: {(Battery? "есть": "нету")}";
    }
}
