namespace Lab6_Misyuro.Kirill;
class Program
{
    static void Main(string[] args)
    {
        List<Figure> figures = new List<Figure>();
        figures.Add(new Triangle() { A = 5 });
        figures.Add(new Circle() { Radius = 3 });
        figures.Add(new Rectangle() { A = 5, B = 10 });
        figures.Add(new Circle() { Radius = 8 });
        figures.Add(new Rectangle() { A = 11, B = 2 });
        double sum = 0;
        foreach (Figure item in figures)
        {
            sum += item.Perimetr;
        }
        Console.WriteLine(sum);
    }
}
