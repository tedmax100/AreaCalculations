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
            if (side < 0 )
            {
                throw new Exception("arguments are small than zero");
            }
            _side = side;
        }

        public double GetArea()
        {
            return _side * _side;
        }
    }
}
