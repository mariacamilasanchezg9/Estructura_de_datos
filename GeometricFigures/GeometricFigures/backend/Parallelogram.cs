namespace GeometricFigures.backend
{
    public class Parallelogram : Rectangle
    {
        private double _h;
        public double H {
                get => _h; set { ValidateH(value); _h = value; 
            } 
        } 

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = h;
        }

        public override double GetArea() => B * H;

        protected void ValidateH(double h) {
            if (h <= 0) throw new ArgumentException("H no válido."); 
        }
    }
}