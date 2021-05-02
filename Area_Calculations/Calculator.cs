using System;
using System.Collections.Generic;
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

        public double GetTotalArea()
        {
            return 0;
        }

        public double GetTotalArea(Square shape)
        {
            return shape.GetArea();
        }

        public double GetTotalArea(Rectangle shape)
        {
            return shape.GetArea();
        }

        public double GetTotalArea(IShape[] shapes)
        {
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.GetArea();
            }
            return totalArea;
        }
    }
}
