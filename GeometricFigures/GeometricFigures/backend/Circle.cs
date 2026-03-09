namespace GeometricFigures.backend
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public double R
        {
            get => _r;
            set { ValidateR(value); _r = value; }
        }

        public Circle(string name, double r) : base(name)
        {
            R = r;
        }

        public override double GetArea() => Math.PI * Math.Pow(R, 2);
        public override double GetPerimiter() => 2 * Math.PI * R;

        private void ValidateR(double r)
        {
            if (r <= 0) throw new ArgumentException("El radio debe ser mayor que 0.");
        }
    }
}
