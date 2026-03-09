namespace GeometricFigures.backend
{
    public abstract class GeometricFigure
    {
        public string Name { get; set; }

        protected GeometricFigure(string name)
        {
            Name = name;
        }

        public abstract double GetArea();
        public abstract double GetPerimiter();

        public override string ToString()
        {
            return $"{Name,-15} => Area.....: {GetArea(),12:N5}    Perimiter: {GetPerimiter(),12:N5}";
        }
    }
}