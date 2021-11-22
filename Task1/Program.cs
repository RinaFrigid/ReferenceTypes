using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure line = new Line(1, 1, 8, 10);
            Figure cercle = new Circle(1, 2, 5);
            Figure rectangle = new Rectangle(1, 0, 5, 12);
            Figure round = new Round(1, 5, 9, "White");
            Figure ring = new Ring(3, 5, 7, 11);
            List<Figure> figures = new();
            figures.Add(line);
            figures.Add(cercle);
            figures.Add(rectangle);
            figures.Add(round);
            figures.Add(ring);
            foreach (var figure in figures)
            {
                Console.WriteLine(figure.Draw());        
            }
        }
    }
}
