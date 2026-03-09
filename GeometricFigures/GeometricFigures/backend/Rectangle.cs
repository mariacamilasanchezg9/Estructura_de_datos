namespace GeometricFigures.backend
{
    public class Rectangle : Square
    {
        private double _b;
        public double B { 
                get => _b; set { ValidateB(value); _b = value; 
            } 
        }

        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = b;
        }

        public override double GetArea() => A * B;
        public override double GetPerimiter() => 2 * (A + B);

        protected void ValidateB(double b) { 
            if (b <= 0) throw new ArgumentException("B no válido."); 
        }
    }
}
