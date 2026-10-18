using System;
using System.Collections.Generic;
using System.Text;

namespace Home_4;
public class Cat: Participant, ISwimmable, ISpeakable
{
    public int Intelligence;
    public int Legs;
    public Cat(string id, string name, double speed, int iq, int legs)
        :base(id, name, speed)
    {
        Intelligence = iq;
        Legs = legs;
    }
    public override void Move() => Console.WriteLine($"{Name} крадется");
    public void Swim() => Console.WriteLine($"{Name} плохо плавает");
    public void Speak() => Console.WriteLine($"{Name} мяукает");
    public override string GetInfo()
    {
        return base.GetInfo() + $", интеллект: {Intelligence}, лапы: {Legs}";
    }

}
