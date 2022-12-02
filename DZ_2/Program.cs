//Напишите программу, которая принимает на вход
//три числа и выдает максимальное из этих чисел.

Console.Write("Enter 1st number: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter 2nd number: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Enter 3th number: ");
int number3 = int.Parse(Console.ReadLine());

int max = number1;
if(max < number2)
{
    max = number2;
}
if(max < number3)
{
    max = number3;
}

Console.WriteLine($"Max number = {max}");
