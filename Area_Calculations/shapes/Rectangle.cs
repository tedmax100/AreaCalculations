using System;
using System.Collections.Generic;
using System.Text;

namespace Area_Calculations.shapes
{
    public class Rectangle : IShape
    {
        private int width;
        private int length;
        public Rectangle(int width, int length)
        {
            this.width = width;
            this.length = length;
        }

        public double GetArea()
        {
            return this.width * this.length;
        }
    }
}
