using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Lab_6
{
    class Car
    {
        private string Windows;
        public void Open() => Windows = "Opened";
        public void Close() => Windows = "Closed";
        public void ShowWindows() => Console.Write(Windows);
        public string VIN { get; }
        public Car(string x)
        {
            VIN = x;
            speed = 0;
            fuel = 0;
            engineOn = false;
            Windows = "Closed";
        }
        public string color { get; init; }
        private int speed;
        public int Speed
        {
            get => speed;
            set
            {
                if (value > 200)
                    throw new ArgumentException("Слишком высокая скорость");
                if (value < 0)
                    throw new ArgumentException("Скорость не может быть меньше 0");
                speed = value;
            }
        }
        private double fuel;
        public void Refuel(double x)
        {
            if (x <= 0)
                throw new ArgumentException("Должно быть больше 0");
            if (fuel + x > 60)
                throw new ArgumentException("бак переполнен");
            fuel += x;

        }
        private bool engineOn;
        public void startengine()
        {
            if (fuel <= 0)
                throw new InvalidOperationException("нет бензина");
            engineOn = true;
        }
        public void stopengine() => engineOn = false;
        public void accelerate(int a)
        {
            Speed += a;
        }
        public void Break(int a)
        {
            Speed -= a;
        }
        public void ShowParams()
        {
            Console.WriteLine($"VIN:      {VIN}");
            Console.WriteLine($"Цвет:     {color}");
            Console.WriteLine($"Двигатель:{(engineOn ? "работает" : "выключен")}");
            Console.WriteLine($"Скорость: {speed} kph");
            Console.WriteLine($"Топливо:  {fuel} l");
            Console.WriteLine($"Окна:     {Windows}");
            
        }



    }
}
