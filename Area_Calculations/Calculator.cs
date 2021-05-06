using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Area_Calculations.shapes;


namespace Area_Calculations
{
    public interface IShape
    {
        double GetArea();
    } 
    public class Calculator
    {
        public Calculator() { }
        public double GetTotalArea(IShape[] shapes)
        {
            return shapes.Sum(shape => shape.GetArea());
        }
    }
}
