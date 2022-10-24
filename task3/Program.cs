// Написать программу масштабирования фигуры
// задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"

int[] b1 = { 0, 0 };
int[] b2 = { 2, 0 };
int[] b3 = { 2, 2 };
int[] b4 = { 0, 2 };
int k = 2;

Console.WriteLine("Координаты масштабированной фигуры: ");

foreach (int element in b1)
{
    int newb1 = element * k;
    Console.Write($"{newb1} ");
}
Console.WriteLine();
foreach (int element in b2)
{
    int newb2 = element * k;
    Console.Write($"{newb2} ");
}
Console.WriteLine();
foreach (int element in b3)
{
    int newb3 = element * k;
    Console.Write($"{newb3} ");
}
Console.WriteLine();
foreach (int element in b4)
{
    int newb4 = element * k;
    Console.Write($"{newb4} ");
}


