using System;
using System.Collections.Generic;
using System.Text;

namespace Home_4;
public class MechaSpider: Participant
{
    public bool Battery;
    public MechaSpider(string id, string name, double speed, bool battery)
        : base(id, name, speed)
    {
        Battery = battery;
    }
    public override void Move() => Console.WriteLine($"{Name} ползает");
    public override string GetInfo()
    {
        return base.GetInfo() + $", Батарейка: {(Battery ? "есть" : "нету")}";
    }
}
