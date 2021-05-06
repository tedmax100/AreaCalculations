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
            _width = width;
            _height = height;
        }

        public double GetArea()
        {
            return _width * _height  * 0.5;
        }
    }
}
