using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapeIdentifier.Tests
{
    [TestClass]
    public class TriangleTest
    {

        [TestMethod]
        [DataRow(1.0, 1.0, 1.0)]
        [DataRow(1.0, 2.0, 2.0)]
        [DataRow(5.0, 4.0, 2.0)]
        [DataRow(1.5, 1.5, 1.5)]
        [DataRow(1.3, 1.3, 1.1)]
        [DataRow(1.9, 1.2, 1.8)]
        [DataRow(20.123, 20.123, 20.123)]
        [DataRow(50.223, 75.98885757, 50.223)]
        [DataRow(102.558899, 150.918273456, 124.99532)]
        public void IsValidBySides_ShouldReturnTrue_WhenTwoSidesSummedAreGreaterThanTheThirdSide(double a, double b, double c)
        {
            Assert.IsTrue(Triangle.IsValidBySides(a, b, c));
        }

        [TestMethod]
        [DataRow()]
        public void IsValidBySides_ShouldReturnFalse_WhenAnyTwoSidesSummedAreLesserOrEqualToTheThirdSide()
        {
        }

        [TestMethod]
        public void IsEquilateral_()
        {
        }

        [TestMethod]
        public void IsIsosceles_()
        {
        }

        [TestMethod]
        public void IsScalene_()
        {
        }

        [TestMethod]
        public void GetTypeBySides_()
        {
        }
    }
}