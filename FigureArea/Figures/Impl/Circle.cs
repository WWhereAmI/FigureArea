using FigureSquare.Figures;

namespace FigureArea.Figures.Impl
{
    public class Circle : IFigure
    {
        private double _radius;

        public double Radius 
        {
            get => _radius;
            private set 
            { 
                _radius = value <= 0 ? throw new ArgumentOutOfRangeException(nameof(_radius), "Radius cannot be less than zero or equals to it.") : value; 
            }

        }


        public Circle(double radius)
        {
            Radius = radius;
        }


        public double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
