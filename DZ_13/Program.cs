//Напишите программу, которая задаёт массив
//из 8 элементов и выводит их на экран.

int lenght = 8;
int[] array = new int[lenght];
Console.WriteLine("Введите числа массива через 'Enter' ");

void ReadArray(int[] array)
{
    int index = 0;
    while (index < lenght)
    {
        array[index] = int.Parse(Console.ReadLine()!);
        index++;
    }
}
void PrintArray(int[] array)
{
    int index = 0;
    while (index < lenght)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}
ReadArray(array);
Console.Write("Массив в строку ");
PrintArray(array);