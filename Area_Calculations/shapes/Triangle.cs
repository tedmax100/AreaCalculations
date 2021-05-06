using System;
using System.Collections.Generic;
using System.Text;

namespace Area_Calculations.shapes
{
    public class Triangle : IShape
    {
        private readonly int _width;
        private readonly int _height;
 
        public Triangle(int width, int height)
        {
            this._width = width;
            this._height = height;
        }

        public double GetArea()
        {
            return this._width * this._height  * 0.5;
        }
    }
}
