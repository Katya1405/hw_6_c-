// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2,
// b1 k1 и b2 и k2 заданы

Console.Write("Введите значение переменной b1: ");
int b1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите значение переменной k1: ");
int k1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите значение переменной b2: ");
int b2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите значение переменной k2: ");
int k2 = int.Parse(Console.ReadLine() ?? "0");
int x = 1;

if (k1 != k2)
{
    int xСoordinate = k1 * x + b1 - k2 * x - b2;
    int yCoordinate = k1 * xСoordinate + b1;
    Console.WriteLine($"Точка пересения заданных прямых: x = {xСoordinate}; y = {yCoordinate}");
}

else if (k1 * x + b1 == k2 * x + b2)
    Console.WriteLine("Прямые совпадают, т.е. имеют бесконечное множество точек пересечения");

else
    Console.WriteLine("Прямые не имеют точек пересечения (они параллельны)");




