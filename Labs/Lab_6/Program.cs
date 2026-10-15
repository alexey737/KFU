using System;
using Lab_6;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car("SALLPAMJ4TA3333333") { color = "Black"};
            bmw.Open();
            bmw.ShowParams();
            bmw.Refuel(40);
            bmw.startengine();
            bmw.accelerate(120);
            bmw.Break(20);
            bmw.ShowParams();

            
        }
    }
}
