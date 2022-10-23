namespace Application;

public class Triangulo
{
    public static float Perimetro(float lado1, float lado2, float lado3)
    {
        float perimetro = lado1 + lado2 + lado3;
        return perimetro;
    }
    public static float Area(float _base, float altura)
    {
        float area = ((_base * altura) / 2);
        return area;
    }
}