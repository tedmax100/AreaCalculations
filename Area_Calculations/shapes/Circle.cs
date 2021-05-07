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
            if (radius < 0)
            {
                throw new Exception("arguments are small than zero");
            }
            _radius = radius;

        }

        public double GetArea()
        {
            return _radius * _radius * 3.14;
        }
    }
}
