using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Round : Circle
    {
        public Round(int x, int y, int radius, string color) : base(x, y, radius)
        {
            Color = color;
        }
        public string Color { get; set; }
        public override string Draw()
        {
            return string.Format("Обьект круг:\nЦентр круга ({0};{1})\nРадиус: {2}\nЦвет: {3}\n", X, Y, Radius, Color);
        }
    }
}
