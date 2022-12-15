﻿//Напишите программу, которая заполнит спирально массив 4 на 4.

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int number = 0;
System.Console.Write("Введите число для создания спирального массива: ");
number = Convert.ToInt32(Console.ReadLine());
int[,] spiralArray = new int[number, number];
int count = 1;
int i = 0;
int j = 0;

while (count <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
{
    spiralArray[i, j] = count;
    count++;
    if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= spiralArray.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > spiralArray.GetLength(1) - 1)
        j--;
    else
        i--;
}
printArray(spiralArray);