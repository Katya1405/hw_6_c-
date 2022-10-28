// Показать числа Фибоначчи

Console.Write("Введите число, чтобы рассчитать для него числа Фибоначчи: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int fibNum0 = 0;
int fibNum1 = 1;

Console.WriteLine("Ряд Фибонначи: ");
Console.Write(fibNum0 + " ");
Console.Write(fibNum1 + " ");
int value = 0;

while (value <= n)
{
    value = fibNum0 + fibNum1;
    Console.Write(value + " ");
    fibNum0 = fibNum1;
    fibNum1 = value;
}

