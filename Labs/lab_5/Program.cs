using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Student a1 = new Student();
            a1.name = "Alexey";
            a1.age = 18;
            a1.Print();
            Person p = new Person("Alex", 18);
            Book b = new Book();
            Book b1 = new Book("war and peace");
            Person p1 = p;
            p1.name = "Nikita";
            Console.Write(p.name);
            Point c1 = new Point();
            c1.x = 10;
            c1.y = 20;
            Point c2 = c1;
            c2.x = 30;
            c2.y = 40;
            c1.Print();
            c2.Print();
            Rectangle d = new Rectangle();
            d.width = 10;
            d.height = 20;
            Console.Write(d.GetArea());
            Balance x  = new Balance();
            x.sum = 100;
            x.Add(200);
            x.Sub(500);
          
        }
    }
}
