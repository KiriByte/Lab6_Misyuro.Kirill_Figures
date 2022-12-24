namespace Lab6_Misyuro.Kirill
{
    public class Triangle : Figure
    {
        public float A { get; set; }
        public override float Perimetr { get { return 3 * A; } }
        public override float Square { get { return (float)Math.Sqrt(3) / 4 * (A * A); } }
    }
}