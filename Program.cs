// Задача 1: Напишите программу, которая на вход принимает
//позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание,
//что такого элемента нет.
int [,] FillArray(int columns, int rows, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = rnd.Next(minValue, maxValue+1);
        }
    }
    return array;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}
void GetElement(int[,] arr, int row, int col)
{
    if (row < 0 | col < 0 | row >= arr.GetLength(0) | col >= arr.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine($"В строке {row} в столбце {col} находится {arr[row, col]}");
    }
}
int [,] arr = FillArray(5, 5, 0, 10);
PrintArray(arr);
GetElement(arr, 5, 4);