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
            Console.WriteLine("Calcula el area y perimetro del triangulo");
            Console.WriteLine();
            
            Console.Write("Escribe la  base: ");
            float _base = Convert.ToSingle(Console.ReadLine());

            Console.Write("Escribe la altura: ");
            float altura = Convert.ToSingle(Console.ReadLine());

           Console.Write("Escribe el lado 1: "); 
            float lado1 = Convert.ToSingle(Console.ReadLine());
            
            Console.Write("Escribe el lado 2: "); 
            float lado2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Escribe el lado 3: "); 
            float lado3 = Convert.ToSingle(Console.ReadLine());


            float perimetro=Application.Triangulo.Perimetro(lado1,lado2,lado3);
            float area=Application.Triangulo.Area(_base, altura);

            Console.WriteLine();

            Console.WriteLine("El area es : " + area.ToString("n4"));
            Console.WriteLine("El perimetro es : "+ perimetro.ToString("n4"));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Presione cualquier tecla para terminar....");
            Console.ReadKey();
        }
    }
}