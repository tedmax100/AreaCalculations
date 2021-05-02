using System;
using System.Collections.Generic;
using System.Text;

namespace Area_Calculations.shapes
{
    public class Circle : IShape
    {
        private int radius;
        public Circle(int radius)
        {
            this.radius = radius;

        }

        public double GetArea()
        {
            return this.radius * this.radius * 3.14;
        }
    }
}
