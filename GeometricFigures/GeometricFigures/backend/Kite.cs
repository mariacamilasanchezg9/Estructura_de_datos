namespace GeometricFigures.backend
{
    public class Kite : Rhombus
    {
        private double _b;
        public double B { get => _b; set { ValidateB(value); _b = value; } }

        public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
        {
            B = b;
        }

        public override double GetPerimiter() => 2 * (A + B);

        protected void ValidateB(double b) {
            if (b <= 0) throw new ArgumentException("B no válido."); 
        }
    }
}