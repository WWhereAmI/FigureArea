using FigureArea.Figures.Impl;
using FigureSquare.Figures;

namespace FigureArea.Tests.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(12, 15, 12, 70.256227)]
        [InlineData(10, 7, 4, 10.928746)]
        [InlineData(5, 7, 4,  9.797959)]
        public void GetArea_ValidInputs_ExpectedArea(double sideA, double sideB, double sideC, double expected)
        {
            //Arrange

            IFigure triangle = new Triangle(sideA, sideB, sideC);

            //Act

            var result = triangle.GetArea();

            //Assert

            Assert.Equal(expected, result, 0.000001);
        }


        [Theory]
        [InlineData(5, 1, -1)]
        [InlineData(213, 22222, 5)]
        [InlineData(1, 2, 3)]
        [InlineData(0, 0, 0)]
        public void Initial_InValidInputs_ArgumentExceptionThrown(double sideA, double sideB, double sideC)
        {
            //Arrange & Act & Assert

            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(3, 5, 4, true)]
        [InlineData(3, 5, 3, false)]
        public void IsTriangleRectangular_ValidInputs_ArgumentOutOfRangeExceptionThrown(double sideA, double sideB, double sideC, bool expected)
        {
            //Arrange

            IFigure triangle = new Triangle(sideA, sideB, sideC);

            //Act

            var result = (triangle as Triangle)?.IsTriangleRectangular() ?? false;

            //Assert

            Assert.Equal(result, expected);

        }


    }
}
