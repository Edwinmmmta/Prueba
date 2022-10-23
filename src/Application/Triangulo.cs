namespace Application;

public class Triangulo
{
    public static double Perimetro(double lado1, double lado2, double lado3)
    {
        double perimetro = lado1 + lado2 + lado3;
        return perimetro;
    }
    public static double Area(double _base, double altura)
    {
        double area = ((_base * altura) / 2);
        return area;
    }
}