// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void SumM(int[,] firstM, int[,] secondM, int[,] sumM, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sumM[i, j] = firstM[i, j] * secondM[i, j];
        }
    }
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк матриц: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов матриц: ");
int columns = int.Parse(Console.ReadLine());

int[,] firstM = GetArray(rows, columns, 0, 10);
PrintArray(firstM);
Console.WriteLine();

int[,] secondM = GetArray(rows, columns, 0, 10);
PrintArray(secondM);
Console.WriteLine();

int[,] sumM = GetArray(rows, columns, 0, 10);
SumM(firstM, secondM, sumM, rows, columns);
Console.WriteLine($"Произведение двух матриц: ");
PrintArray(sumM);