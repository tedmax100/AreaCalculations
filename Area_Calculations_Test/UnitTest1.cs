using NUnit.Framework;
using Area_Calculations;
using Area_Calculations.shapes;
using System;

namespace Area_Calculations_Test
{
    public class Tests
    {
        private Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void GetTotalAreaToBeZero()
        {
            var totalArea = calculator.GetTotalArea(new IShape[] {  });
            Assert.AreEqual(0, totalArea);
        }

        [Test]
        public void SquareArea()
        {
            var square = new Square(10);
            var totalArea = calculator.GetTotalArea(new IShape[] { square });
            Assert.AreEqual(100, totalArea);
        }

        [Test]
        public void RectangleArea()
        {
            var rectangle = new Rectangle(2,3);
            var totalArea = calculator.GetTotalArea(new IShape[] { rectangle });
            Assert.AreEqual(6, totalArea);
        }

        [Test]
        public void CircleArea()
        {
            var circle = new Circle(1);
            var totalArea = calculator.GetTotalArea(new IShape[] { circle });
            Assert.AreEqual(3.14, totalArea);
        }

        [Test]
        public void TriangleArea()
        {
            var triangle = new Triangle(3,4);
            var calculator = new Calculator();
            var totalArea = calculator.GetTotalArea(new IShape[] { triangle });
            Assert.AreEqual(6, totalArea);
        }

        [Test]
        public void RectangleWithSquareArea()
        {
            var rectangle = new Rectangle(2, 3);
            var square = new Square(10);
            var triangle = new Triangle(3, 4);
            var circle = new Circle(1);
            var totalArea = calculator.GetTotalArea(new IShape[] { rectangle, square, triangle , circle });
            Assert.AreEqual(115.14, totalArea);
        }
    }
}