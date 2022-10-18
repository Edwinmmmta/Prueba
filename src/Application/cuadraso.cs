namespace Application;

public class Cuadrado
{
    public static double Perimetro(double lado)
    {
        double perimetro = lado + lado + lado + lado;
        return perimetro;
    }
    public static double Area(double lado)
    {
        double area = lado * lado;
        return area;
    }
}