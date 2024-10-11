using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProject1
{
    [TestClass]
    public class AbstractAndInterfacesTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AbstractShape_Should_Throw_Exception_When_Instantiated()
        {
            //Act & Assert
            {
                throw new InvalidOperationException("Cannot instantiate an abstract class.");
            }  // Should throw exception as Shape is abstract
        }

        [TestMethod]
        public void Circle_Should_Override_AbstractMethods_Correctly()
        {
            //Arrange
           Shape circle = new Circle { Radius = 3 };

            //Act
           var area = circle.Area();

            //Assert
            Assert.AreEqual(28.2743, area, 0.0001);
        }

        [TestMethod]
        public void Rectangle_Should_Override_AbstractMethods_Correctly()
        {
            //Arrange
            Shape rectangle = new Rectangle { Width = 5, Height = 2 };

            //Act
           var area = rectangle.Area();

            //Assert
            Assert.AreEqual(10, area);
        }
    }
}

