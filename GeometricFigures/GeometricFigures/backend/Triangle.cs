namespace GeometricFigures.backend
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;

        public double C { 
                get => _c; set { ValidateC(value); _c = value; 
            } 
        }
        public double H {
            get => _h; set { 
                ValidateH(value); _h = value; 
            }
        }

        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            C = c;
            H = h;
        }

        public override double GetArea() => (B * H) / 2;
        public override double GetPerimiter() => A + B + C;

        protected void ValidateC(double c) { 
            if (c <= 0) throw new ArgumentException("C no válido."); 
        }
        protected void ValidateH(double h) { 
            if (h <= 0) throw new ArgumentException("H no válido."); 
        }
    }
}
