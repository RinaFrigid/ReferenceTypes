using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Rectangle : Line
    {
        public Rectangle(int x, int y, int endx, int endy) : base(x, y, endx, endy)
        {

        }
        public override string Draw()
        {
            return string.Format("Обьект прямоугольник:\nдлина: {0}\nширина: {1}\n", Math.Abs(EndX - X), Math.Abs(Y - EndY));
        }
    }
}
