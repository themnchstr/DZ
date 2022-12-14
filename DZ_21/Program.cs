//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetMatrix(int rows, int columns, int minNumber, int maxNumber)
{
    int[,] matrix = new int[rows, columns];

    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minNumber, maxNumber);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++) //m
    {
        for (int j = 0; j < mtrx.GetLength(1); j++) //n
        {
            if (j == 0) Console.Write(" | ");
            Console.Write($"{mtrx[i, j], 1} | ");
        }
        Console.WriteLine();
    }
}

void AverageOfColumns(int[,] mtrx)
{
    double sum = 0;

    for (int j = 0; j < mtrx.GetLength(1); j++)
    {
        for (int i = 0; i < mtrx.GetLength(0); i++)
        {
            sum += mtrx[i, j];
        }

        if (j == 0) Console.WriteLine("Среднее арифметическое по столбцам:");
        Console.WriteLine($" {Math.Round(sum / mtrx.GetLength(0), 2)}");

        sum = 0;
    }
}

int[,] array = GetMatrix(3, 4, 0, 10);
PrintMatrix(array);
Console.WriteLine();
AverageOfColumns(array);