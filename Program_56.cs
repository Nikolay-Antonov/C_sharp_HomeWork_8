// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// 
// Например, задан массив:
// 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// 
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] FillArray()
{
    int[,] array = new int[rows, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
    return array;
}


string FindMinRow(int[,] arr)
{
    int minSum = int.MaxValue;
    int minRow = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int currentSum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            currentSum += arr[i, j];
        }
        if (currentSum < minSum)
        {
            minSum = currentSum;
            minRow = i;
        }
    }
    return $"Строка с минимальной суммой элементов - {minRow + 1}, сумма = {minSum}";
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
int[,] massiv = FillArray();
Console.WriteLine($"Двумерный массив {rows} x {column} : ");
PrintArray(massiv);
Console.WriteLine(FindMinRow(massiv));