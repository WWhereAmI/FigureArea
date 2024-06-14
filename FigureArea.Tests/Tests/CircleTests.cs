using FigureArea.Figures.Impl;
using FigureSquare.Figures;

namespace FigureArea.Tests.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(5, 78.539816)]
        [InlineData(10, 314.159265)]
        [InlineData(1, 3.141593)]
        public void GetArea_ValidInputs_ExpectedArea(double radius, double expected)
        {
            //Arrange

            IFigure circle = new Circle(radius);

            //Act

            var result = circle.GetArea();

            //Assert

            Assert.Equal(expected, result, 0.000001);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        public void Initial_InValidInputs_ArgumentOutOfRangeExceptionThrown(double radius)
        {
            //Arrange & Act & Assert

            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }
    }
}