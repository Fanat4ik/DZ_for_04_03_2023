// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//Формула для нахождения кротчайшего расстояния между 2 точками в пространстве:
// AB = √((Xb-Xa)^2+(Yb-Ya)^2+(Yb-Ya)^2)

//функция(метод) принимает на вход координаты в виде 6 переменных double
double DistanceAB(double aX, double aY, double aZ, double bX, double bY, double bZ)
{
    double result = Math.Sqrt(Math.Pow((bX-aX),2) + Math.Pow((bY-aY),2) + Math.Pow((bZ-aZ),2));
    return result;
}

//ввод координат из консоли
Console.WriteLine("ввод координат точки А (последовательно Х  Y  Z): ");
double aX = Convert.ToDouble(Console.ReadLine());
double aY = Convert.ToDouble(Console.ReadLine());
double aZ = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ввод координат точки А (последовательно Х  Y  Z): ");
double bX = Convert.ToDouble(Console.ReadLine());
double bY = Convert.ToDouble(Console.ReadLine());
double bZ = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"координаты А ( {aX} ; {aY} ; {aZ} )");
Console.WriteLine($"координаты B ( {bX} ; {bY} ; {bZ} )");

double distanveAB = DistanceAB(aX, aY, aZ, bX, bY, bZ);
Console.WriteLine($"длина от точки A до точки B = {distanveAB}");
