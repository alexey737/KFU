using System;
using System.Collections.Generic;
using System.Text;

namespace Home_4;
public abstract class Participant
{
    public string Id { get; }
    public string Name { get; }
    public double Speed;
    protected Participant(string id, string name, double speed)
    {
        Id = id;
        Name = name;
        Speed = speed;
    }
    public abstract void Move();
    public virtual string GetInfo() => $"Имя: {Name}, ID: {Id}   скорость: {Speed}";
}
public interface IFlyable
{
    void Fly();
}
public interface ISwimmable
{
    void Swim();
}
public interface ISpeakable
{
    void Speak();
}