﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Ring : Circle
    {
        public Ring(int x, int y, int radius, int radius2) : base(x, y, radius)
        {
            Radius2 = radius2;
        }
        public int Radius2 { get; set; }
        public override void Draw()
        {
            Console.WriteLine("Обьект кольцо:\nЦентр кольца ({0};{1})\nширина кольца: {2}\nРадиус внутренней окружности: {3}\nРадиус внешней окружности: {4}\n", X, Y, Math.Abs(Radius-Radius2), Math.Min(Radius,Radius2), Math.Max(Radius,Radius2));
        }
    }
}