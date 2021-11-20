using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Line : Figure
    {
        public Line(int x, int y, int endx, int endy) : base(x,y)
        {
            EndX = endx;
            EndY = endy;
        }
        public int EndX { get; set; }
        public int EndY { get; set; }
        public override void Draw()
        {
            Console.WriteLine("Обьект линия:\nНачало ({0};{1})\nКонец ({2};{3})\n", X, Y, EndX, EndY);
        }
    }
}
