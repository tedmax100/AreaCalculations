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
        public void ShouldTotalAreaToBeZero()
        {
            var totalArea = calculator.GetTotalArea();
            Assert.AreEqual(0, totalArea);
        }
        
        [Test]
        public void ShouldGetExceptionWhenGivenNegativeArgumentForShape()
        {
            Assert.Throws<Exception>(() => new Square(-1), "arguments are small than zero");
            Assert.Throws<Exception>(() => new Triangle(-1, 0), "arguments are small than zero");
            Assert.Throws<Exception>(() => new Circle(-1), "arguments are small than zero");
            Assert.Throws<Exception>(() => new Rectangle(-1,0), "arguments are small than zero");
        }

        [Test]
        public void TestSquareArea()
        {
            var square = new Square(10);
            var totalArea = calculator.GetTotalArea(square);
            Assert.AreEqual(100, totalArea);
        }

        [Test]
        public void TestRectangleArea()
        {
            var rectangle = new Rectangle(2,3);
            var totalArea = calculator.GetTotalArea( rectangle );
            Assert.AreEqual(6, totalArea);
        }

        [Test]
        public void TestCircleArea()
        {
            var circle = new Circle(1);
            var totalArea = calculator.GetTotalArea( circle );
            Assert.AreEqual(3.14, totalArea);
        }

        [Test]
        public void TestTriangleArea()
        {
            var triangle = new Triangle(3,4);
            var calculator = new Calculator();
            var totalArea = calculator.GetTotalArea(triangle );
            Assert.AreEqual(6, totalArea);
        }

        [Test]
        public void TestGetTotalAreaWithMultiShapes()
        {
            var rectangle = new Rectangle(2, 3);
            var square = new Square(10);
            var triangle = new Triangle(3, 4);
            var circle = new Circle(1);
            var circle2 = new Circle(2);
            var totalArea = calculator.GetTotalArea( rectangle, square, triangle , circle , circle2);
            Assert.AreEqual(127.7, totalArea);
        }
    }
}