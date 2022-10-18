double lado = 5;
double altura = 10;
double perimetro = Application.Cuadrado.Perimetro(lado);
double area = Application.Cuadrado.Area(lado);
double volumen = Application.PrismaCuadrangular.Volumen(area, altura);

Console.WriteLine($"El perímetro de la base de un Prisma Cuadrangular de {lado}cm por lado es {perimetro}cm");
Console.WriteLine($"El área de la base de un Prisma Cuadrangular de {lado}cm por lado es {area}cm2");
Console.WriteLine($"El volumen un Prisma Cuadrangular con un área de la base de {area}cm2 y {altura}cm de altura es {volumen}cm3");