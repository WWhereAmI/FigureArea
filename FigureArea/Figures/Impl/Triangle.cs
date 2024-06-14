using FigureSquare.Figures;


namespace FigureArea.Figures.Impl
{
    public class Triangle : IFigure
    {
        public double SideA { get; private set; }

        public double SideB { get; private set; }

        public double SideC { get; private set; }



        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsValidTriangle(sideA, sideB, sideC))
                throw new ArgumentException("Triangle side cannot be less than sum of the others.");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        private bool IsValidTriangle(double sideA, double sideB, double sideC)
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }



        public double GetArea()
        {
            double p = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool IsTriangleRectangular()
        {
            return (SideA * SideA + SideB * SideB == SideC * SideC)
                        || (SideA * SideA + SideC * SideC == SideB * SideB)
                        || (SideC * SideC + SideB * SideB == SideA * SideA);
        }
    }
}
