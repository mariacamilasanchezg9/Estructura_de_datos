namespace GeometricFigures.backend
{
    public class Square : GeometricFigure
    {
        private double _a;

        public double A
        {
            get => _a;
            set { ValidateA(value); _a = value; }
        }

        public Square(string name, double a) : base(name)
        {
            A = a;
        }

        public override double GetArea() => Math.Pow(A, 2);
        public override double GetPerimiter() => 4 * A;

        protected void ValidateA(double a)
        {
            if (a <= 0) throw new ArgumentException("El lado A debe ser mayor que 0.");
        }
    }
}