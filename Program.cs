using System;


interface IParent
{
    string Info();
    double Metod1(); // Площа повної поверхні
    double Metod2(); // Об'єм
}

//тетраедр
class Child1 : IParent
{
    private double pole1; // Довжина ребра

    public Child1(double edgeLength)
    {
        pole1 = edgeLength;
    }

    public string Info()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        return $"Тетраедр: Довжина ребра = {pole1}, Площа повної поверхні = {Math.Round(Metod1(), 1)}, Об'єм = {Math.Round(Metod2(), 1)}";
    }

    public double Metod1()
    {
        return Math.Sqrt(3) * pole1 * pole1;
    }

    public double Metod2()
    {
        return (pole1 * pole1 * pole1) / (6 * Math.Sqrt(2));
    }
}

//  куб
class Child2 : IParent
{
    private double pole1; // Довжина ребра

    public Child2(double edgeLength)
    {
        pole1 = edgeLength;
    }

    public string Info()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        return $"Куб: Довжина ребра = {pole1}, Площа повної поверхні = {Math.Round(Metod1(), 1)}, Об'єм = {Math.Round(Metod2(), 1)}";
    }

    public double Metod1()
    {
        return 6 * pole1 * pole1;
    }

    public double Metod2()
    {
        return pole1 * pole1 * pole1;
    }
}

class Program
{
    static void Main()
    {
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            double edgeLength = Math.Round(random.NextDouble() * 30, 1); // Величина ребра випадкова від 0 до 10, заокруглена до десятих

            int objectType = random.Next(2); // 1 - тетраедр, 2 - куб

            IParent shape = null;

            if (objectType == 0)
                shape = new Child1(edgeLength);
            else
                shape = new Child2(edgeLength);

            Console.WriteLine(shape.Info());
        }
    }
}
