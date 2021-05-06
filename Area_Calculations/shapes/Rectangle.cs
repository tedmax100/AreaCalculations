﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Area_Calculations.shapes
{
    public class Rectangle : IShape
    {
        private readonly int _width;
        private readonly int _length;
        public Rectangle(int width, int length)
        {
            this._width = width;
            this._length = length;
        }

        public double GetArea()
        {
            return this._width * this._length;
        }
    }
}
