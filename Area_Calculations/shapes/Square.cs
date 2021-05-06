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
            this._side = side;
        }

        public double GetArea()
        {
            return this._side * this._side;
        }
    }
}
