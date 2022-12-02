//Напишите программу, которая на вход принимает
//два числа и выдает, какое число большее, а какое меньшее.

Console.Write("Enter number 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter number 2: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("number 1 more number 2");
}
else if (number1 < number2)
{
    Console.WriteLine("number 2 more number 1");
}
else
{
    Console.WriteLine("number 1 equally number 2");
}

