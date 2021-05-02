using System;
using System.Collections.Generic;
using System.Text;

namespace Area_Calculations.shapes
{
    public class Triangle : IShape
    {
        private int width;
        private int height;
 
        public Triangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public double GetArea()
        {
            return this.width * this.height  * 0.5;
        }
    }
}
