namespace GeometricFigures.backend
{
    public class Trapeze : Triangle
    {
        private double _d;
        public double D { get => _d; set { 
                ValidateD(value); _d = value; 
            } 
        }

        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
        {
            D = d;
        }

        public override double GetArea() => ((B + D) * H) / 2;
        public override double GetPerimiter() => A + B + C + D;

        protected void ValidateD(double d) { 
            if (d <= 0) throw new ArgumentException("D no válido."); 
        }
    }
}
