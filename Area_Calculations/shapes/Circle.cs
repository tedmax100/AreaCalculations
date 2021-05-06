using System;
using System.Collections.Generic;
using System.Text;

namespace Area_Calculations.shapes
{
    public class Circle : IShape
    {
        private readonly int _radius;
        public Circle(int radius)
        {
            this._radius = radius;

        }

        public double GetArea()
        {
            return this._radius * this._radius * 3.14;
        }
    }
}
