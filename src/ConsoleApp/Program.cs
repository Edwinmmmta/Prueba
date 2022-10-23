/*
double lado = 5;
double altura = 10;
double perimetro = Application.Cuadrado.Perimetro(lado);
double area = Application.Cuadrado.Area(lado);
double volumen = Application.PrismaCuadrangular.Volumen(area, altura);

Console.WriteLine($"El perímetro de la base de un Prisma Cuadrangular de {lado}cm por lado es {perimetro}cm");
Console.WriteLine($"El área de la base de un Prisma Cuadrangular de {lado}cm por lado es {area}cm2");
Console.WriteLine($"El volumen un Prisma Cuadrangular con un área de la base de {area}cm2 y {altura}cm de altura es {volumen}cm3");
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            print("calcula el area y perimetro del triangulo");
            float _base = float(input("Escribe la base "));
            float altura = float(input("escribe la altura "));
            float lado1 = float(input("escribe el lado 1 "));
            float lado2 = float(input("escribe el lado 2 "));
            float lado3 = float(input("escribe el lado 3 "));

            float perimetro=Application.Triangulo.Perimetro(lado1,lado2,lado3);
            float area=Application.Triangulo.Area(_base, altura);

            print("el area es : ", area);
            print("el perimetro es : ", perimetro);
        }
    }
}