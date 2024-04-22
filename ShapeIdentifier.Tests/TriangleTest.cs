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
        [DataRow(1, 1, 2)]
        [DataRow(2.222, 1.111, 1.0001)]
        [DataRow(15.12, 20.2, 200.3)]
        public void IsValidBySides_ShouldReturnFalse_WhenAnyTwoSidesSummedAreLesserOrEqualToTheThirdSide(double a, double b, double c)
        {
            Assert.IsFalse(Triangle.IsValidBySides(a, b, c));
        }

        [TestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(10.5, 10.5, 10.5)]
        [DataRow(100.208, 100.208, 100.208)]
        public void IsEquilateral_ShouldReturnTrue_WhenAllTrheeSidesAreOfEqualLength(double a, double b, double c)
        {
            Assert.IsTrue(Triangle.IsEquilateral(a, b, c));
        }

        [TestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(10.5, 10.5, 10.0)]
        [DataRow(100.207, 100.208, 100.208)]
        public void IsEquilateral_ShouldReturnFalse_WhenAllThreeSidesAreNotOfEqualLengthOrTheTriangleIsInvalid(double a, double b, double c)
        {
            Assert.IsFalse(Triangle.IsEquilateral(a, b, c));
        }

        [TestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(1, 1, 1.5)]
        [DataRow(200.123, 200, 200.123)]
        public void IsIsosceles_ShouldReturnTrue_WhenAtleastTwoSidesAreOfEqualLength(double a, double b, double c)
        {
            Assert.IsTrue(Triangle.IsIsosceles(a, b, c));
        }

        [TestMethod]
        [DataRow(1, 2, 2.5)]
        [DataRow(15.555, 16.666, 17.777)]
        [DataRow(212.123456789, 375.982151, 298.55232)]
        public void IsIsosceles_ShouldReturnFalse_WhenNoneOfTheSidesAreOfEqualLengthOrTheTriangleIsInvalid(double a, double b, double c)
        {
            Assert.IsFalse(Triangle.IsIsosceles(a, b, c));
        }

        [TestMethod]
        [DataRow(1, 2, 2.5)]
        [DataRow(15.555, 16.666, 17.777)]
        [DataRow(212.123456789, 375.982151, 298.55232)]
        public void IsScalene_ShouldReturnTrue_WhenNoSidesAreOfEqualLength(double a, double b, double c)
        {
            Assert.IsTrue(Triangle.IsScalene(a, b, c));
        }

        [TestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(1, 1.5, 1)]
        [DataRow(25.5555, 75.1231231, 2.9)]
        public void IsScalene_ShouldReturnFalse_WhenAllSidesAreNotOfEqualLengthOrTriangleIsInvalid(double a, double b, double c)
        {
            Assert.IsFalse(Triangle.IsScalene(a, b, c));
        }

        [TestMethod]
        public void GetTypeBySides_ShouldReturnDegenerate_WhenIsValidBySidesReturnsFalse()
        {
            // Arrange
            var expected = TriangleType.Degenerate;
            var a = 5.12345;
            var b = 20345.123412;
            var c = 5.12345;

            // Act
            var actual = Triangle.GetTypeBySides(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTypeBySides_ShouldReturnEquilateral_WhenAllSidesAreEqual()
        {
            // Arrange
            var expected = TriangleType.Equilateral;
            var a = 1234.56789;
            var b = 1234.56789;
            var c = 1234.56789;

            // Act
            var actual = Triangle.GetTypeBySides(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTypeBySides_ShouldReturnIsosceles_WhenTwoSidesAreEqual()
        {
            // Arrange
            var expected = TriangleType.Isosceles;
            var a = 0.82475;
            var b = 1.23459;
            var c = 0.82475;

            // Act
            var actual = Triangle.GetTypeBySides(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTypeBySides_ShouldReturnScalene_WhenNoSidesAreEqual()
        {
            // Arrange
            var expected = TriangleType.Scalene;
            var a = 50.5125;
            var b = 72.8558;
            var c = 67.2222;

            // Act
            var actual = Triangle.GetTypeBySides(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}