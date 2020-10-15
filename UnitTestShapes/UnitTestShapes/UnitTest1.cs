using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;



namespace UnitTestShapes
{

    [TestClass]

    public class AverageTests
    {
        List<Ishape> shapes = CreateShapesFromFile.CreateList(@"Shapes_example.txt");
        [TestMethod]
        public void AveragePerimeter()
        {
            double expected = 33.76;
            double actual = Calculations.perimeterAverage(shapes);
            Assert.AreEqual(expected, actual,0.01);
        }
        [TestMethod]
        public void AverageSquare()
        {
            double expected = 76.7;
            double actual = Calculations.squareAverage(shapes);
            Assert.AreEqual(expected, actual, 0.01);
        }
        [TestMethod]
        public void MaxSquare()
        {
            Ishape expected = shapes[4];
            Ishape actual = Calculations.maxSquare(shapes);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TypeShapeMaxAveragePerimeter()
        {
            TypeShapes expected = TypeShapes.Трапеция;
            TypeShapes actual = Calculations.typeShapeMaxAveragePerimeter(shapes);
            Assert.AreEqual(expected, actual);
        }
    }
}
