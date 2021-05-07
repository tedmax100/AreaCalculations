using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Area_Calculations.shapes;


namespace Area_Calculations
{
    /// <summary>
    /// IShape is a interface for definition the behavior about shape that calculator need.
    /// GetArea():double => return the area of the shape
    /// </summary>
    public interface IShape
    {
        double GetArea();
    } 
    
    /// <summary>
    /// Calculator for calculation with shapes
    /// </summary>
    public class Calculator
    {
        public double GetTotalArea(params IShape[] shapes)
        {
            return Math.Round(shapes.Sum(shape => shape.GetArea()), 2);
        }
    }
}
