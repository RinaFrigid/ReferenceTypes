using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure line = new Line(5, 3, 10, 6);
            line.Draw();
            Figure cercle = new Circle(1, 1, 10);
            cercle.Draw();
            Figure rectangle = new Rectangle(5, 3, 10, 6);
            rectangle.Draw();
            Figure round = new Round(1, 1, 5, "White");
            round.Draw();
            Figure ring = new Ring(1, 1, 5, 10);
            ring.Draw();
        }
    }
}
