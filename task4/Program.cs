// Написать программу копирования массива

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

void CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    Console.WriteLine("Копия представленного массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
        Console.Write($"{copyArray[i]} ");
    }
}

int[] array = new int[5];

FillArray(array);
PrintArray(array);
Console.WriteLine();
CopyArray(array);