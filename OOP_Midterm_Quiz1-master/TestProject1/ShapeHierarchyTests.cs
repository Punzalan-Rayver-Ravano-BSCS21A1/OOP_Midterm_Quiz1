using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    [TestClass]
    public class ShapeHierarchyTests
    {
        [TestMethod]
        public void Circle_Should_Calculate_Area_Correctly()
        {
            // Arrange
            Circle circle = new Circle(6) ;

            // Act
            double area = circle.Area(4);

            // Assert
            Assert.AreEqual(Math.PI * 5 * 5, area);
        }

        [TestMethod]
        public void Rectangle_Should_Calculate_Area_Correctly()
        {
            // Arrange
            Rectangle rectangle = new Rectangle (4,6,0);

            // Act
            double area = rectangle.Area(4);

            // Assert
            Assert.AreEqual(24, area);
        }

        [TestMethod]
        public void Circle_Should_Implement_IColorable()
        {
            // Arrange
            Circle circle = new Circle(6);

            // Act & Assert
            Assert.IsInstanceOfType(circle, typeof(IColorable));
        }

        [TestMethod]
        public void Circle_Should_Paint_Correctly()
        {
            // Arrange
            Circle circle = new Circle(6);

            // Act
            var paintResult = circle.Paint("Red");

            // Assert
            Assert.AreEqual("Painting the circle Red.", paintResult);
        }
    }
}
