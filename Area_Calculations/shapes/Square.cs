using System;
using System.Collections.Generic;
using System.Text;
using Area_Calculations;

namespace Area_Calculations.shapes
{
    public class Square : IShape
    {
        private int side;
        public Square(int side)
        {
            this.side = side;
        }

        public double GetArea()
        {
            return this.side * this.side;
        }
    }
}
