using System;
using System.Collections.Generic;
using System.Text;
using Area_Calculations;

namespace Area_Calculations.shapes
{
    public class Square : IShape
    {
        private readonly int _side;
        public Square(int side)
        {
            _side = side;
        }

        public double GetArea()
        {
            return _side * _side;
        }
    }
}
